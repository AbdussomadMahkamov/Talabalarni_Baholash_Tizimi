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
            GetFan();
            ShowTable();
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
        public void ShowTable()
        {
            string Query;
            Query = "Select Guruh, Id, Ism, Familya From Talabalar where Guruh='{0}';";
            Query = string.Format(Query,
                guruhCombo.Text);
            BaholarData.DataSource = Con.GetData(Query);
        }

        private void baholarFill_Click(object sender, EventArgs e)
        {
            ShowTable();
        }
    }
}
