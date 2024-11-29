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
    public partial class Guruhlar : Form
    {
        Functions Con;
        public Guruhlar()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTable();
        }
        public void ShowTable()
        {
            string Query;
            Query = "Select * From Guruhlar";
            guruhlarData.DataSource = Con.GetData(Query);
        }

        private void addTalaba_Click(object sender, EventArgs e)
        {
            string Query1;
            Query1 = "insert into Guruhlar(Nomi, Tarif) values('{0}', '{1}');";
            Query1 = string.Format(Query1,
                guruhNomiTxt.Text,
                guruhTarifiTxt.Text);
            Con.SetData(Query1);
            ShowTable();
        }

        private void editTalaba_Click(object sender, EventArgs e)
        {
            if (guruhNomiTxt.Text != "")
            {
                string Query2 = "select Nomi from Guruhlar where Nomi='" + guruhNomiTxt.Text + "';";
                DataTable dt = new DataTable();
                dt = Con.GetData(Query2);
                if (dt.Rows.Count > 0)
                {
                    string Query3 = "update Guruhlar set Tarif='{0}' where Nomi='{1}';";
                    Query3 = string.Format(Query3,
                        guruhTarifiTxt.Text,
                        guruhNomiTxt.Text);
                    Con.SetData(Query3);
                    ShowTable();
                }
                else
                {
                    MessageBox.Show("Bunday ma'lumot topilmadi", "Eslatma");
                }
            }
            else
            {
                MessageBox.Show("Iltimos guruh nomini kiriting!", "Eslatma");
            }
        }

        private void deleteTalaba_Click(object sender, EventArgs e)
        {
            string Query4;
            Query4 = "delete from Guruhlar where Nomi='{0}';";
            Query4 = string.Format(Query4,
                guruhNomiTxt.Text);
            Con.SetData(Query4);
            ShowTable();
        }
    }
}
