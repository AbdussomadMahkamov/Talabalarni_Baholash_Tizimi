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
    public partial class Form1 : Form
    {
        Functions Con;
        public Form1()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query1 = "select Name, Password, Type from Users where Name='" + loginTxt.Text + "' and Password='" + parolTxt.Text + "';";
            DataTable dt = new DataTable();
            dt = Con.GetData(Query1);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "Admin")
                {
                    Users users = new Users();
                    users.Show();
                    this.Hide();
                }
                else
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Parol yoki Login noto'gri kiritildi. Iltimos tekshirib qayta tering!", "Bildirishnoma");
            }
        }
    }
}
