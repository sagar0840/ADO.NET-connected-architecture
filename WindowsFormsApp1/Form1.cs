using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Xml.Linq;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"server=DESKTOP-EFR1DG0\SQLEXPRESS02;Database=DotNet20Dec;Integrated Security=True;");

        }

        
        

        private void btnsave1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into employee7 values(@name,@salary)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtsalary.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update employee7 set name=@name, salary=@salary where id=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtsalary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnsearch1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from employee7 where id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       txtname.Text = dr["name"].ToString();
                       txtsalary.Text = dr["salary"].ToString();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from employee7 where id=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnshowallemployee1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from employee7";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dr);
                    dataGridView2.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }   
}
