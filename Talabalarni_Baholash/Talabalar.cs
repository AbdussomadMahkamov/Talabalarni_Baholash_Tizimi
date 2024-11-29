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
    public partial class Talabalar : Form
    {
        Functions Con;
        public Talabalar()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTable();
            GetGuruh();
        }
        public void ShowTable()
        {
            string Query;
            Query = "Select * From Talabalar";
            talabalarData.DataSource = Con.GetData(Query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(
                    ismTxt.Text == ""||
                    familyaTxt.Text == ""||
                    yoshTxt.Text == ""||
                    manzilTxt.Text == ""
                    )
                    MessageBox.Show("Iltimos maydonlarni to'ldiring", "Eslatma");
                else
                {
                    string Query1 = "insert into Talabalar(Ism, Familya, Yosh, Telefon, Manzil) values ('{0}', '{1}', '{2}', '{3}', '{4}');";
                    Query1 = string.Format(Query1,
                        ismTxt.Text,
                        familyaTxt.Text,
                        Convert.ToInt32(yoshTxt.Text),
                        telefonTxt.Text,
                        manzilTxt.Text);
                    Con.SetData(Query1);
                    ShowTable();
                    MessageBox.Show("Ma'lumotlar muvoffaqiyatli saqlandi", "Bildirishnoma");
                }
                    ismTxt.Text = "";
                    familyaTxt.Text = "";
                    yoshTxt.Text = "";
                    telefonTxt.Text = "";
                    manzilTxt.Text = "";
                    idTalabaTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
                //throw;
            }
        }

        private void editTalaba_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    ismTxt.Text == "" ||
                    familyaTxt.Text == "" ||
                    yoshTxt.Text == "" ||
                    manzilTxt.Text == ""||
                    idTalabaTxt.Text == ""
                    )
                    MessageBox.Show("Iltimos maydonlarni to'ldiring", "Eslatma");
                else
                {
                    string Query3 = "update Talabalar set Ism='{0}', Familya='{1}', Yosh='{2}', Telefon='{3}', Manzil='{4}' where Id='{5}'";
                    Query3 = string.Format(Query3,
                        ismTxt.Text,
                        familyaTxt.Text,
                        Convert.ToInt32(yoshTxt.Text),
                        telefonTxt.Text,
                        manzilTxt.Text,
                        idTalabaTxt.Text);
                    Con.SetData(Query3);
                    ShowTable();
                    MessageBox.Show("Ma'lumotlar muvoffaqiyatli tahrirlandi", "Bildirishnoma");
                }
                ismTxt.Text = "";
                familyaTxt.Text = "";
                yoshTxt.Text = "";
                telefonTxt.Text = "";
                manzilTxt.Text = "";
                idTalabaTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
            }
        }

        private void deleteTalaba_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from Talabalar where Id='{0}'";
                Query = string.Format(Query, idTalabaTxt.Text);
                Con.SetData(Query);
                ShowTable();
                MessageBox.Show("Ma'lumotlar muvoffaqiyatli o'chirildi", "Bildirishnoma");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
            }
        }

        private void findTalaba_Click(object sender, EventArgs e)
        {
            Con = new Functions();
            string Query2 = "Select * From Talabalar where Id = "+ idTalabaTxt.Text + ";";
            talabalarData.DataSource = Con.GetData(Query2);
            ismTxt.Text = talabalarData.Rows[0].Cells[1].Value.ToString();
            familyaTxt.Text = talabalarData.Rows[0].Cells[2].Value.ToString();
            yoshTxt.Text = talabalarData.Rows[0].Cells[3].Value.ToString();
            telefonTxt.Text = talabalarData.Rows[0].Cells[4].Value.ToString();
            manzilTxt.Text = talabalarData.Rows[0].Cells[5].Value.ToString();
        }
        private void GetGuruh()
        {
            string Query4 = "Select * From Guruhlar";
            guruhCombo.DisplayMember = Con.GetData(Query4).Columns["Nomi"].ToString();
            guruhCombo.ValueMember = Con.GetData(Query4).Columns["Id"].ToString();
            guruhCombo.DataSource = Con.GetData(Query4);
        }

        private void guruhBiriktirish_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTalabaTxt.Text == "" || guruhCombo.SelectedIndex == -1)
                {
                    MessageBox.Show("Iltimos maydonni ma'lumot bilan to'ldiring", "Bildirishnoma");
                }
                else
                {
                    string Query5 = "update Talabalar set Guruh='{0}'  where Id='{1}'";
                    Query5 = string.Format(Query5,
                        guruhCombo.Text, 
                        idTalabaTxt.Text);
                    Con.SetData(Query5);
                    ShowTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bildirishnoma");
            }
        }
    }
}
