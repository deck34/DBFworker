using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace DBFCleaner
{
    public partial class MainForm : Form
    {
        string DBF_FileName = "";

        public MainForm()
        {
            InitializeComponent();
        }

        void init()
        {
        }

        void DeleteData()
        {
            var d_fr = dtpFrom.Value;
            var d_to = dtpTo.Value;

            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DBF_FileName + ";Collating Sequence=machine;");
            string filter = " DATE between {" + d_fr.Month.ToString() + "/" + d_fr.Day.ToString() + "/" + d_fr.Year.ToString() + "} and {" + d_to.Month.ToString() + "/" + d_to.Day.ToString() + "/" + d_to.Year.ToString() + "}";
            string dcom = "DELETE FROM " + DBF_FileName + " WHERE id = ' 2VW' AND value like '%A%' AND" + filter;
            
            string pcom = "pack " + DBF_FileName; //OPEN DATABASE testdata
            string req = "";
            if (cbFilter.Checked == true)
            {
                req += "DELETE FROM " + DBF_FileName;
                if (cbDate.Checked || cbWhere.Checked)
                {
                    req += " WHERE ";
                }
                if (cbWhere.Checked)
                {
                    req += rtbReqWh.Text;
                }
                if (cbDate.Checked)
                {
                    if (cbWhere.Checked)
                    {
                        req += " AND ";
                    }
                    req += " DATE between {" + d_fr.Month.ToString() + "/" + d_fr.Day.ToString() + "/" + d_fr.Year.ToString() + "} and {" + d_to.Month.ToString() + "/" + d_to.Day.ToString() + "/" + d_to.Year.ToString() + "}";
                }
            }
            else
            {
                req += dcom;
            }
            OleDbCommand command = new OleDbCommand(req, conn);
            OleDbCommand command_pack = new OleDbCommand(pcom, conn);
            //open the connection and read in all the airport data from .dbf file into a datatable
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            conn.Open();
            //DataTable dt = new DataTable();
            command.ExecuteNonQuery();
            conn.Close(); //close connection to the .dbf file
            sw.Stop();
            var t = Convert.ToDouble(sw.ElapsedMilliseconds);
            rtbOut.AppendText("Пометка на удаление строк с "+ d_fr.ToShortDateString()+" по "+ d_to.ToShortDateString() + " - "+ t/1000 +" сек.\n");
            sw.Reset();
            sw.Start();
            conn.Open();
            command_pack.ExecuteNonQuery();
            //dt.Load(command.ExecuteReader());
            conn.Close(); //close connection to the .dbf file
            sw.Stop();
            t = Convert.ToDouble(sw.ElapsedMilliseconds);
            rtbOut.AppendText("Упаковка базы - " + t/1000 + " сек.\n");
            //dgvReq.DataSource = dt;

            MessageBox.Show("Delete successful");
        }

        void ViewData()
        {
            var d_fr = dtpFrom.Value;
            var d_to = dtpTo.Value;

            OleDbConnection conn = new OleDbConnection(@"Provider=vfpoledb;Data Source=" + DBF_FileName + ";Collating Sequence=machine;");
            string filter = " WHERE DATE between {" + d_fr.Month.ToString() + "/" + d_fr.Day.ToString() + "/" + d_fr.Year.ToString() + "} and {" + d_to.Month.ToString() + "/" + d_to.Day.ToString() + "/" + d_to.Year.ToString() + "}";
            string scom = "SELECT * FROM " + DBF_FileName;
            string filter1 = " WHERE id = ' 2VW'"; //"  143E   "
            string filter2 = " WHERE sp3850 = '     A                 '"; //'     A                 '
            string filter3 = " WHERE code like '%80119%'"; //'901740             '
            string req = "";
            if (cbFilter.Checked==true)
            {
                if (cbSel.Checked)
                {
                    req += "SELECT ";
                    req += rtbReqSel.Text;
                }
                else
                {
                    req += "SELECT * ";
                }
                req += " FROM " + DBF_FileName;
                if (cbDate.Checked || cbWhere.Checked)
                {
                    req += " WHERE ";
                }
                if (cbWhere.Checked)
                {
                    req += rtbReqWh.Text;
                }
                if (cbDate.Checked)
                {
                    if(cbWhere.Checked)
                    {
                        req += " AND ";
                    }
                    req += " DATE between {" + d_fr.Month.ToString() + "/" + d_fr.Day.ToString() + "/" + d_fr.Year.ToString() + "} and {" + d_to.Month.ToString() + "/" + d_to.Day.ToString() + "/" + d_to.Year.ToString() + "}";
                }
            }
            else
            {
                req += scom;
                if (cbDate.Checked)
                {
                    req += filter;
                }
            }
            OleDbCommand command = new OleDbCommand(req, conn);
            //OleDbCommand command_pack = new OleDbCommand(pcom, conn);
            //open the connection and read in all the airport data from .dbf file into a datatable
            conn.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            conn.Close(); //close connection to the .dbf file
            dgvReq.DataSource = dt;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы dbf|*.dbf";
            string File = "";
            OPF.Multiselect = false;

            if (OPF.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OPF.FileNames)
                {
                    File = file;
                }
                if (File.Length == 0)
                    MessageBox.Show("Не удалось прочитать файл!\n", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception("Файл пуст");
                DBF_FileName = OPF.FileName;
                tbFileName.Text = OPF.FileName;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (DBF_FileName == "")
            {
                MessageBox.Show("Не удалось прочитать файл!\n", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rtbOut.Clear();
            rtbOut.AppendText("Запрос выполняется...\n");
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            ViewData();
            sw.Stop();
            var t = Convert.ToDouble(sw.ElapsedMilliseconds);
            rtbOut.AppendText("Запрос выполнен за " + t / 1000 + " сек.\n");
            rtbOut.AppendText("Показано строк: " + dgvReq.Rows.Count+"\n");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DBF_FileName == "")
            {
                MessageBox.Show("Не удалось прочитать файл!\n", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rtbOut.Clear();
            DeleteData();
        }

        private void btnClearDGV_Click(object sender, EventArgs e)
        {
            dgvReq.DataSource = null;
            dgvReq.Rows.Clear();
            dgvReq.Refresh();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            var d_fr = dtpFrom.Value;
            var d_to = dtpTo.Value;
            string filter = "DATE between {" + d_fr.Month.ToString() + "/" + d_fr.Day.ToString() + "/" + d_fr.Year.ToString() + "} and {" + d_to.Month.ToString() + "/" + d_to.Day.ToString() + "/" + d_to.Year.ToString() + "}";
            rtbReqWh.Clear();
            rtbReqWh.AppendText(" id = ' 2VW' AND value like '%A%'");
        }
    }
}
