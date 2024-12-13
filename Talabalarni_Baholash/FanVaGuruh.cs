using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talabalarni_Baholash
{
    public partial class FanVaGuruh : Form
    {
        Functions Con;
        public FanVaGuruh()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTable();
            GetGuruh();
            GetFan();
        }
        public void ShowTable()
        {
            string Query;
            Query = "Select * From FanVaGuruh;";
            fanVaGuruhData.DataSource = Con.GetData(Query);
        }
        private void GetGuruh()
        {
            string Query1 = "Select * From Guruhlar";
            guruhCombo.DisplayMember = Con.GetData(Query1).Columns["Nomi"].ToString();
            guruhCombo.ValueMember = Con.GetData(Query1).Columns["Id"].ToString();
            guruhCombo.DataSource = Con.GetData(Query1);
        }
        private void GetFan()
        {
            string Query2 = "Select * From Fanlar";
            fanCombo.DisplayMember = Con.GetData(Query2).Columns["Nomi"].ToString();
            fanCombo.ValueMember = Con.GetData(Query2).Columns["Id"].ToString();
            fanCombo.DataSource = Con.GetData(Query2);
        }

        private void connectGroupSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if(guruhCombo.SelectedIndex == -1 || fanCombo.SelectedIndex == -1)
                {
                    MessageBox.Show("Iltimos maydonni ma'lumot bilan to'ldiring", "Bildirishnoma");
                }
                else
                {
                    string Query3 = "insert into FanVaGuruh(Guruh, Fan) values ('{0}', '{1}');";
                    Query3 = string.Format(Query3,
                        guruhCombo.Text,
                        fanCombo.Text);
                    Con.SetData(Query3);
                    ShowTable();
                    GetGuruh();
                    GetFan();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query4;
            Query4 = "Select * From FanVaGuruh where Guruh='{0}';";
            Query4 = string.Format(Query4,
                guruhCombo.Text);
            fanVaGuruhData.DataSource = Con.GetData(Query4);
            string[] guruh = guruhCombo.Text.Split('-');
            string guruh1 = guruh[0] + '_' + guruh[1];
            string qatorda = "CREATE TABLE [dbo].[Baho_"+guruh1+ "](" +
                "[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, " +
                "[Guruh] VARCHAR(50) NOT NULL," +
                "[Talaba_Id] INT NOT NULL, " +
                "[Ism] VARCHAR(50) NOT NULL," +
                "[Familya] VARCHAR(50) NOT NULL,";
            //MessageBox.Show(qatorda, "Bildirishnoma");
            string fanlar = "";
            int i = 0;
            int son = fanVaGuruhData.Rows.Count;
            foreach(DataGridViewRow row in fanVaGuruhData.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    fanlar += "[" + row.Cells[2].Value.ToString() + "] INT NULL";
                    if (i != son - 2)
                    {
                        fanlar += ",";
                    }
                    //MessageBox.Show(row.Cells[2].Value.ToString(), "Bildirishnoma");
                }
                else
                {
                    break;
                }
                i++;
                
            }
            qatorda += fanlar + ");";
            Con.SetData(qatorda);
            MessageBox.Show("Guruhga fanlar qo'shildi!", "Bildirishnoma!");

        }
    }
}
