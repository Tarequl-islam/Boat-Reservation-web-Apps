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
    public partial class Save_Boat : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public Save_Boat()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-A3NPCLEH;Initial Catalog=BoatReservationDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            boatGridView.DataSource = GetBoatList();
        }
        private void Save_Boat_Load(object sender, EventArgs e)
        {

        }

        private void sailorButton_Click(object sender, EventArgs e)
        {
            Sailors sailor = new Sailors();
            sailor.Show();
            this.Hide();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void boatButton_Click(object sender, EventArgs e)
        {

        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.Show();
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (nameTextBox.Text==String.Empty || colorTextBox.Text=="")
            {
                outputlabel.Text = "Please enter all the input";
            }
            else
            {
                Boat boat = new Boat();
                boat.Name = nameTextBox.Text;
                boat.Color = colorTextBox.Text;
                if (IsNameExist(boat.Name))
                {
                    outputlabel.Text = "Name already Exist. Try another!";
                }
                else
                {
                    int rowEffect = Save(boat);
                    if (rowEffect >= 1)
                    {
                        outputlabel.Text = "Save Successful.";
                        nameTextBox.Text = "";
                        colorTextBox.Text = "";
                    }
                    else outputlabel.Text = "Save Failed!";
                }

            }
            boatGridView.DataSource = GetBoatList();
        }

        public List<Boat> GetBoatList()
        {
            string query = "SELECT * FROM Boats";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Boat> boatList = new List<Boat>();
            while (reader.Read())
            {
                Boat boat = new Boat();
                boat.Id = Convert.ToInt32(reader["bid"]);
                boat.Name = reader["bname"].ToString();
                boat.Color = reader["color"].ToString();
                boatList.Add(boat);
            }
            connection.Close();
            return boatList;
        }
        public int Save(Boat boat)
        {
            string query = "INSERT INTO Boats(bname, color) VALUES(@bname, @color)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@bname", boat.Name);
            command.Parameters.AddWithValue("@color", boat.Color);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
        public bool IsNameExist(string name)
        {
            string query = "SELECT * FROM Boats WHERE bname = @name";
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
