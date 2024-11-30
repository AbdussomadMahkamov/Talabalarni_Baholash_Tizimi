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
    public partial class Oqituvchilar : Form
    {
        Functions Con;
        public Oqituvchilar()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTable();
        }
        public void ShowTable()
        {
            string Query;
            Query = "Select * From Oqituvchilar;";
            oqituvchilarData.DataSource = Con.GetData(Query);
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    ismTxt.Text == "" ||
                    familyaTxt.Text == "" ||
                    yoshTxt.Text == "" ||
                    manzilTxt.Text == ""
                    )
                    MessageBox.Show("Iltimos maydonlarni to'ldiring", "Eslatma");
                else
                {
                    string Query1 = "insert into Oqituvchilar(Ism, Familya, Yosh, Telefon, Manzil, Fan) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";
                    Query1 = string.Format(Query1,
                        ismTxt.Text,
                        familyaTxt.Text,
                        Convert.ToInt32(yoshTxt.Text),
                        telefonTxt.Text,
                        manzilTxt.Text,
                        fanTxt.Text);
                    Con.SetData(Query1);
                    ShowTable();
                    MessageBox.Show("Ma'lumotlar muvoffaqiyatli saqlandi", "Bildirishnoma");
                }
                ismTxt.Text = "";
                familyaTxt.Text = "";
                yoshTxt.Text = "";
                telefonTxt.Text = "";
                manzilTxt.Text = "";
                fanTxt.Text = "";
                idOqituvchiTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
                //throw;
            }
        }

        private void editTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    ismTxt.Text == "" ||
                    familyaTxt.Text == "" ||
                    yoshTxt.Text == "" ||
                    manzilTxt.Text == "" ||
                    idOqituvchiTxt.Text == ""
                    )
                    MessageBox.Show("Iltimos maydonlarni to'ldiring", "Eslatma");
                else
                {
                    string Query3 = "update Oqituvchilar set Ism='{0}', Familya='{1}', Yosh='{2}', Telefon='{3}', Manzil='{4}', Fan='{5}' where Id='{6}'";
                    Query3 = string.Format(Query3,
                        ismTxt.Text,
                        familyaTxt.Text,
                        Convert.ToInt32(yoshTxt.Text),
                        telefonTxt.Text,
                        manzilTxt.Text,
                        fanTxt.Text,
                        idOqituvchiTxt.Text);
                    Con.SetData(Query3);
                    ShowTable();
                    MessageBox.Show("Ma'lumotlar muvoffaqiyatli tahrirlandi", "Bildirishnoma");
                }
                ismTxt.Text = "";
                familyaTxt.Text = "";
                yoshTxt.Text = "";
                telefonTxt.Text = "";
                manzilTxt.Text = "";
                fanTxt.Text = "";
                idOqituvchiTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
            }
        }

        private void deleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from Oqituvchilar where Id='{0}'";
                Query = string.Format(Query, idOqituvchiTxt.Text);
                Con.SetData(Query);
                ShowTable();
                MessageBox.Show("Ma'lumotlar muvoffaqiyatli o'chirildi", "Bildirishnoma");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
            }
        }

        private void findTeacher_Click(object sender, EventArgs e)
        {
            Con = new Functions();
            string Query2 = "Select * From Oqituvchilar where Id = " + idOqituvchiTxt.Text + ";";
            oqituvchilarData.DataSource = Con.GetData(Query2);
            ismTxt.Text = oqituvchilarData.Rows[0].Cells[1].Value.ToString();
            familyaTxt.Text = oqituvchilarData.Rows[0].Cells[2].Value.ToString();
            yoshTxt.Text = oqituvchilarData.Rows[0].Cells[3].Value.ToString();
            telefonTxt.Text = oqituvchilarData.Rows[0].Cells[4].Value.ToString();
            manzilTxt.Text = oqituvchilarData.Rows[0].Cells[5].Value.ToString();
        }
    }
}
