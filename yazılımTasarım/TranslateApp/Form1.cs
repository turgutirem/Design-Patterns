using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TranslateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBIslemleri dbConnect = new DBIslemleri();
        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnect.ConnectionControl(CoennctionAdress._connection);
            SqlCommand command = new SqlCommand("Select EnglishMean from Translate ", CoennctionAdress._connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());

            }
            CoennctionAdress._connection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // listBox1.Items.Clear();
            dbConnect.ConnectionControl(CoennctionAdress._connection);
            SqlCommand command = new SqlCommand("Select TurkceAnlam from Translate where EnglishMean=@p", CoennctionAdress._connection);//içinde a olanları seçtik 
            command.Parameters.AddWithValue("@p",listBox1.SelectedItem);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbxTurkce.Text = reader[0].ToString();

            }
            CoennctionAdress._connection.Close();
            // tbxTurkce.Text = listBox1.SelectedItem.ToString();
        }

        private void tbxIngilizce_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dbConnect.ConnectionControl(CoennctionAdress._connection);
            SqlCommand command = new SqlCommand("Select EnglishMean from Translate where EnglishMean like '"+tbxIngilizce.Text+"%'" , CoennctionAdress._connection);//içinde a olanları seçtik 
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]);

            }
            CoennctionAdress._connection.Close();
        }
    }
}
