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
    public partial class Baholar : Form
    {
        Functions Con;
        public Baholar()
        {
            InitializeComponent();
            Con = new Functions();
            GetGuruh();
            string[] guruh = guruhCombo.Text.Split('-');
            string guruh1 = guruh[0] + '_' + guruh[1];
            ShowTable(guruh1);
            GetFan();
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
        public void ShowTable(string guruh)
        {
            string Query;
            Query = "IF EXISTS (SELECT 1 " +
                "FROM INFORMATION_SCHEMA.TABLES " +
                "WHERE TABLE_NAME = 'Baho_{0}') " +
                "BEGIN " +
                "SELECT * FROM Baho_{0}; " +
                "END";
            Query = string.Format(Query,
                guruh);
            BaholarData.DataSource = Con.GetData(Query);
        }

        private void baholarFill_Click(object sender, EventArgs e)
        {
            string[] guruh = guruhCombo.Text.Split('-');
            string guruh1 = guruh[0] + '_' + guruh[1];
            ShowTable(guruh1);
            GetFan();
        }

        private void addBaho_Click(object sender, EventArgs e)
        {
            string[] guruh = guruhCombo.Text.Split('-');
            string guruh1 = guruh[0] + '_' + guruh[1];
            string Query3 = "update Baho_{0} set '{1}'='{2}' where Guruh='{3}' and Talaba_Id='{4}'";
            Query3 = string.Format(Query3,
                guruh1,
                fanCombo.Text,
                bahoTxt.Text,
                guruhCombo.Text,
                talabaIdTxt.Text);
            Con.SetData(Query3);
            ShowTable(guruh1);
            GetFan();
        }
    }
}
