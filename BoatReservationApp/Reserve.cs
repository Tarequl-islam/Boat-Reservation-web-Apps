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
    public partial class Reserve : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        Sailors sailors =new Sailors();
        Save_Boat boats =new Save_Boat();
        public Reserve()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-A3NPCLEH;Initial Catalog=BoatReservationDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            reserveGridView.DataSource = GetReserveList();
            sailorComboBox.DataSource = sailors.GetSailorList();
            sailorComboBox.DisplayMember ="Name";
            sailorComboBox.ValueMember = "Id";
            boatComboBox.DataSource = boats.GetBoatList();
            boatComboBox.DisplayMember = "Name";
            boatComboBox.ValueMember = "Id";
            
        }
        private void boatButton_Click(object sender, EventArgs e)
        {
            Save_Boat boat = new Save_Boat();
            boat.Show();
            this.Hide();
        }

        private void sailorButton_Click(object sender, EventArgs e)
        {
            Sailors sailor = new Sailors();
            sailor.Show();
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sailorComboBox.Text == String.Empty || boatComboBox.Text == String.Empty)
            {
                outputlabel.Text = "Please enter all the input";
            }
            else
            {
                Resv resv = new Resv();
                resv.Sid = Convert.ToInt32(sailorComboBox.SelectedValue);
                resv.Bid = Convert.ToInt32(boatComboBox.SelectedValue);
                resv.Date = dateTimePicker.Value;
                if (IsNameExist(resv.Bid, String.Format("{0:MM/dd/yyyy}", resv.Date)))
                {
                    outputlabel.Text = "The boat is reserved for the day. Try another!";
                }
                else
                {
                    int rowEffect = Save(resv);
                    if (rowEffect >= 1)
                    {
                        outputlabel.Text = "Save Successful.";
                        sailorComboBox.Text = "";
                        boatComboBox.Text = "";

                        reserveGridView.DataSource = GetReserveList();
                        sailorComboBox.DataSource = sailors.GetSailorList();
                        sailorComboBox.DisplayMember = "Name";
                        sailorComboBox.ValueMember = "Id";
                        boatComboBox.DataSource = boats.GetBoatList();
                        boatComboBox.DisplayMember = "Name";
                        boatComboBox.ValueMember = "Id";
                        
                    }
                    else outputlabel.Text = "Save Failed!";
                }

            }
        }

        public List<Reserv> GetReserveList()
        {
            string query = "SELECT * FROM ReservesView";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Reserv> reserveList = new List<Reserv>();
            while (reader.Read())
            {
                Reserv reserv = new Reserv();
                reserv.Sailor = reader["Sailor_Name"].ToString();
                reserv.Boat = reader["Boat_Name"].ToString();
                reserv.Date = reader["Date"].ToString();
                reserveList.Add(reserv);
            }
            connection.Close();
            return reserveList;
        }
        public int Save(Resv resv)
        {
            string query = "INSERT INTO Reserves(sid, bid, day) VALUES(@sid, @bid, @day)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sid", resv.Sid);
            command.Parameters.AddWithValue("@bid", resv.Bid);
            command.Parameters.AddWithValue("@day", resv.Date);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
        public bool IsNameExist(int bid, string date)
        {
            string query = "SELECT * FROM Reserves WHERE bid = @bid AND day= @date";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@bid", bid);
            command.Parameters.AddWithValue("@date", date);
            connection.Open();
            reader = command.ExecuteReader();
            bool IsExist = reader.HasRows;
            connection.Close();
            return IsExist;
        }
    }
}
