using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cawsworkapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void task1_Click(object sender, EventArgs e)
        {


            try
            {
                string[] stringArray;

                string[] stringArray1;

                label4.Text = "";


                var ds = new DataSet("CSV File");
                var filename = @"D:\work\Data.csv";
                var connString = string.Format(
                    @"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""",
                    Path.GetDirectoryName(filename)
                );
                using (var conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    var query = "SELECT * FROM [" + Path.GetFileName(filename) + "]";
                    using (var adapter = new OleDbDataAdapter(query, conn))
                    {

                        adapter.Fill(ds);
                    }
                }

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    label4.Text = label4.Text + ds.Tables[0].Rows[i]["Full Name (Billing)"].ToString().Replace(" ", ",") + "," + ds.Tables[0].Rows[i]["Address 1"].ToString().Replace("|", ",") + "\n";

                }


            }
            catch (Exception ex)
            {

            }



        }

        private void task2_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";


                Dictionary<string, string> dict = new Dictionary<string, string>();


                var ds1 = new DataSet("CSV File");
                var filename = @"D:\work\Data.csv";
                var connString = string.Format(
                    @"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""",
                    Path.GetDirectoryName(filename)
                );
                using (var conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    var query = "SELECT * FROM [" + Path.GetFileName(filename) + "]";
                    using (var adapter = new OleDbDataAdapter(query, conn))
                    {

                        adapter.Fill(ds1);

                    }
                }


                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {

                    dict.Add(ds1.Tables[0].Rows[i][ds1.Tables[0].Columns[0].ColumnName].ToString(), ds1.Tables[0].Rows[i]["Full Name (Billing)"].ToString());

                }








                var ds2 = new DataSet("CSV File");
                var filename2 = @"D:\work\Data_2.csv";
                var connString2 = string.Format(
                    @"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""",
                    Path.GetDirectoryName(filename2)
                );

                using (var conn = new OleDbConnection(connString2))
                {
                    conn.Open();
                    var query = "SELECT * FROM [" + Path.GetFileName(filename2) + "]";
                    using (var adapter = new OleDbDataAdapter(query, conn))
                    {

                        adapter.Fill(ds2);
                    }
                }

                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    label4.Text = label4.Text + ds2.Tables[0].Rows[i][ds2.Tables[0].Columns[0].ColumnName].ToString()+ "," + ds2.Tables[0].Rows[i]["Id"].ToString()+"," + ds2.Tables[0].Rows[i]["Invoice Amount"].ToString() +","+dict[ds2.Tables[0].Rows[i]["Id"].ToString()] + "\n";

                }

            }
            catch(Exception ex)
            {

            }
        }
    }
}
