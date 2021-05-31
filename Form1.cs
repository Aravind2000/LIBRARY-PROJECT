using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace DBMS_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        


        SqlCommand cmd;
        SqlDataReader dr;
        private string getUsername()
        {
            SqlConnection con = new SqlConnection("@Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Aravind\\source\repos\\dbms(again)\\DBMS project\\Database1.mdf;Integrated Security = True");

            //fetch data
            con.Open();
            String syntax = "SELECT Value FROM Table Where Property=username";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private string getPassword()
        {
            SqlConnection con = new SqlConnection("@Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Aravind\\source\repos\\dbms(again)\\DBMS project\\Database1.mdf;Integrated Security = True");

            //fetch data
            con.Open();
            String syntax = "SELECT Value FROM Table Where Property=password";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("@Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Aravind\\source\repos\\dbms(again)\\DBMS project\\Database1.mdf;Integrated Security = True");

            String Uname = getUsername(), Upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                label4.Hide();
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //dontlogin

                label4.Show();


            }
        }
    }
}
