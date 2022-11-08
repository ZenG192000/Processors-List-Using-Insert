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

namespace Processors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ref_Grid();
        }

        private void Ref_Grid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * FROM ProcessorsTBL", Conclass.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand save = new SqlCommand("INSERT INTO ProcessorsTBL (processor_name, processor_brand, processor_status, processor_launchdate, processor_numcores, processor_maxturbofrequency, processor_basefrequency, processor_cache, processor_TDP, processor_graphics, processor_QTY, processor_price) VALUES (@processor_name, @processor_brand, @processor_status, @processor_launchdate, @processor_numcores, @processor_maxturbofrequency, @processor_basefrequency, @processor_cache, @processor_TDP, @processor_graphics, @processor_QTY, @processor_price)", Conclass.con);
            save.Parameters.AddWithValue("@processor_name", txtPName.Text);
            save.Parameters.AddWithValue("@processor_brand", txtBrand.Text);
            save.Parameters.AddWithValue("@processor_status", txtStatus.Text);
            save.Parameters.AddWithValue("@processor_launchdate", txtLD.Text);
            save.Parameters.AddWithValue("@processor_numcores", txtCores.Text);
            save.Parameters.AddWithValue("@processor_maxturbofrequency", txtMax.Text);
            save.Parameters.AddWithValue("@processor_basefrequency", txtBase.Text);
            save.Parameters.AddWithValue("@processor_cache", txtCache.Text);
            save.Parameters.AddWithValue("@processor_TDP", txtTDP.Text);
            save.Parameters.AddWithValue("@processor_graphics", txtGraphics.Text);
            save.Parameters.AddWithValue("@processor_QTY", txtQuantity.Text);
            save.Parameters.AddWithValue("@processor_Price", txtPrice.Text);

            Conclass.con.Open();
            save.ExecuteNonQuery();

            MessageBox.Show("Added Successfully","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Conclass.con.Close();
            Ref_Grid();
        }
    }
}
