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
    public partial class Fanlar : Form
    {
        Functions Con;
        public Fanlar()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTable();
        }
        public void ShowTable()
        {
            string Query;
            Query = "Select * From Fanlar";
            fanData.DataSource = Con.GetData(Query);
        }

        private void addFan_Click(object sender, EventArgs e)
        {
            string Query1;
            Query1 = "insert into Fanlar(Nomi, Tarif) values('{0}', '{1}');";
            Query1 = string.Format(Query1,
                fanNomiTxt.Text,
                fanTarifiTxt.Text);
            Con.SetData(Query1);
            ShowTable();
        }

        private void editFan_Click(object sender, EventArgs e)
        {
            if (fanNomiTxt.Text != "")
            {
                string Query2 = "select Nomi from Fanlar where Nomi='" + fanNomiTxt.Text + "';";
                DataTable dt = new DataTable();
                dt = Con.GetData(Query2);
                if (dt.Rows.Count > 0)
                {
                    string Query3 = "update Fanlar set Tarif='{0}' where Nomi='{1}';";
                    Query3 = string.Format(Query3,
                        fanTarifiTxt.Text,
                        fanNomiTxt.Text);
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

        private void deleteFan_Click(object sender, EventArgs e)
        {
            string Query4;
            Query4 = "delete from Fanlar where Nomi='{0}';";
            Query4 = string.Format(Query4,
                fanNomiTxt.Text);
            Con.SetData(Query4);
            ShowTable();
        }
    }
}
