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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.panel6.Controls.Count > 0)
                this.panel6.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel6.Controls.Add(f);
            this.panel6.Tag = f;
            f.Show();
        }

        private void talabaBtn_Click(object sender, EventArgs e)
        {
            loadform(new Talabalar());
        }

        private void guruhBtn_Click(object sender, EventArgs e)
        {
            loadform(new Guruhlar());
        }

        private void fanBtn_Click(object sender, EventArgs e)
        {
            loadform(new Fanlar());
        }

        private void uqituvchiBtn_Click(object sender, EventArgs e)
        {
            loadform(new Oqituvchilar());
        }

        private void bahoBtn_Click(object sender, EventArgs e)
        {
            loadform(new Baholar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new FanVaGuruh());
        }
    }
}
