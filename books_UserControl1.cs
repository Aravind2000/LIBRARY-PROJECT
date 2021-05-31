using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace DBMS_project
{
    public partial class books_UserControl1 : UserControl
    {
        private static books_UserControl1 _instance;

        public static books_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new books_UserControl1();
                }
                return _instance;
            }
        }
        public books_UserControl1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        private void books_UserControl1_Load(Object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void label1_Click(Object sender, EventArgs e)
        {

        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBooksData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("     <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void textBox6_TextChanged(Object sender, EventArgs e)
        {

        }

        private void Add_New_Click(Object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accNo", textBox4.Text);
            cmd.Parameters.AddWithValue("@isbn", textBox5.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@publisher", textBox3.Text);
            cmd.Parameters.AddWithValue("@author", textBox6.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("     <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();
            refresh_DataGridView();


        }

        private void dataGridView1_CellContentClick(Object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(Object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Booksdelete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", textBox4.Text);
                con.Open();
                try
                {
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("     <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }
    }
}

