using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoatReservationApp.Model;

namespace BoatReservationApp
{
    public partial class Sailors : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public Sailors()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-A3NPCLEH;Initial Catalog=BoatReservationDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            sailorGridView.DataSource = GetSailorList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void boatButton_Click(object sender, EventArgs e)
        {
            Save_Boat boat = new Save_Boat();
            boat.Show();
            this.Hide();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.Show();
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (nameTextBox.Text==String.Empty ||ageTextBox.Text==String.Empty||ratingTextBox.Text=="")
            {
                outputlabel.Text = "Please enter all the input";
            }
            else
            {
                Sailor sailor = new Sailor();
                sailor.Name = nameTextBox.Text;
                sailor.Age = Convert.ToInt32(ageTextBox.Text);
                sailor.Rating = Convert.ToInt32(ratingTextBox.Text);
                if (IsNameExist(sailor.Name))
                {
                    outputlabel.Text = "Name already Exist. Try another!";
                }
                else
                {
                    int rowEffect = Save(sailor);
                    if (rowEffect >= 1)
                    {
                        outputlabel.Text = "Save Successful.";
                        nameTextBox.Text = "";
                        ageTextBox.Text = "";
                        ratingTextBox.Text = "";
                    }
                    else outputlabel.Text = "Save Failed!";
                }

            }
            sailorGridView.DataSource = GetSailorList();
        }

        public List<Sailor> GetSailorList()
        {
            string query = "SELECT * FROM Sailors";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Sailor> sailorList = new List<Sailor>();
            while (reader.Read())
            {
                Sailor sailor = new Sailor();
                sailor.Id = Convert.ToInt32(reader["sid"]);
                sailor.Name = reader["sname"].ToString();
                sailor.Age = Convert.ToInt32(reader["age"]);
                sailor.Rating = Convert.ToInt32(reader["rating"]);
                sailorList.Add(sailor);
            }
            connection.Close();
            return sailorList;
        }
        public int Save(Sailor sailor)
        {
            string query = "INSERT INTO Sailors(sname, rating, age) VALUES(@sname, @rating, @age)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sname", sailor.Name);
            command.Parameters.AddWithValue("@rating", sailor.Rating);
            command.Parameters.AddWithValue("@age", sailor.Age);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
        public bool IsNameExist(string name)
        {
            string query = "SELECT * FROM Sailors WHERE sname = @name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            connection.Open();
            reader = command.ExecuteReader();
            bool IsExist = reader.HasRows;
            connection.Close();
            return IsExist;
        }
    }
}
