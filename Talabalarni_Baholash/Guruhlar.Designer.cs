
namespace Talabalarni_Baholash
{
    partial class Guruhlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guruhlarData = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteTalaba = new System.Windows.Forms.Button();
            this.editTalaba = new System.Windows.Forms.Button();
            this.addTalaba = new System.Windows.Forms.Button();
            this.guruhTarifiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guruhNomiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guruhlarData)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 44);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guruhlar ro\'yxati";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guruhlarData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 600);
            this.panel1.TabIndex = 2;
            // 
            // guruhlarData
            // 
            this.guruhlarData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guruhlarData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.guruhlarData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guruhlarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guruhlarData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guruhlarData.Location = new System.Drawing.Point(0, 0);
            this.guruhlarData.Name = "guruhlarData";
            this.guruhlarData.Size = new System.Drawing.Size(1011, 600);
            this.guruhlarData.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteTalaba);
            this.panel3.Controls.Add(this.editTalaba);
            this.panel3.Controls.Add(this.addTalaba);
            this.panel3.Controls.Add(this.guruhTarifiTxt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.guruhNomiTxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 644);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 137);
            this.panel3.TabIndex = 3;
            // 
            // deleteTalaba
            // 
            this.deleteTalaba.BackColor = System.Drawing.Color.Red;
            this.deleteTalaba.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteTalaba.Location = new System.Drawing.Point(572, 83);
            this.deleteTalaba.Name = "deleteTalaba";
            this.deleteTalaba.Size = new System.Drawing.Size(115, 36);
            this.deleteTalaba.TabIndex = 15;
            this.deleteTalaba.Text = "O\'chirish";
            this.deleteTalaba.UseVisualStyleBackColor = false;
            this.deleteTalaba.Click += new System.EventHandler(this.deleteTalaba_Click);
            // 
            // editTalaba
            // 
            this.editTalaba.BackColor = System.Drawing.Color.PaleGreen;
            this.editTalaba.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editTalaba.Location = new System.Drawing.Point(725, 83);
            this.editTalaba.Name = "editTalaba";
            this.editTalaba.Size = new System.Drawing.Size(115, 36);
            this.editTalaba.TabIndex = 14;
            this.editTalaba.Text = "Tahrirlash";
            this.editTalaba.UseVisualStyleBackColor = false;
            this.editTalaba.Click += new System.EventHandler(this.editTalaba_Click);
            // 
            // addTalaba
            // 
            this.addTalaba.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTalaba.Location = new System.Drawing.Point(867, 83);
            this.addTalaba.Name = "addTalaba";
            this.addTalaba.Size = new System.Drawing.Size(115, 36);
            this.addTalaba.TabIndex = 13;
            this.addTalaba.Text = "Qo\'shish";
            this.addTalaba.UseVisualStyleBackColor = false;
            this.addTalaba.Click += new System.EventHandler(this.addTalaba_Click);
            // 
            // guruhTarifiTxt
            // 
            this.guruhTarifiTxt.Location = new System.Drawing.Point(16, 89);
            this.guruhTarifiTxt.Name = "guruhTarifiTxt";
            this.guruhTarifiTxt.Size = new System.Drawing.Size(348, 27);
            this.guruhTarifiTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ta\'rif";
            // 
            // guruhNomiTxt
            // 
            this.guruhNomiTxt.Location = new System.Drawing.Point(16, 37);
            this.guruhNomiTxt.Name = "guruhNomiTxt";
            this.guruhNomiTxt.Size = new System.Drawing.Size(348, 27);
            this.guruhNomiTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomi";
            // 
            // Guruhlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 781);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Guruhlar";
            this.Text = "Guruhlar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guruhlarData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox guruhTarifiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guruhNomiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView guruhlarData;
        private System.Windows.Forms.Button deleteTalaba;
        private System.Windows.Forms.Button editTalaba;
        private System.Windows.Forms.Button addTalaba;
    }
}