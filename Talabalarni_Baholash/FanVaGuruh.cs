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
    }
}
