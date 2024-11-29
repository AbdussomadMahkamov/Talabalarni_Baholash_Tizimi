
namespace Talabalarni_Baholash
{
    partial class Fanlar
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteFan = new System.Windows.Forms.Button();
            this.editFan = new System.Windows.Forms.Button();
            this.addFan = new System.Windows.Forms.Button();
            this.fanTarifiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fanNomiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fanData = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanData)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(995, 44);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fanlar ro\'yxati";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fanData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 554);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteFan);
            this.panel3.Controls.Add(this.editFan);
            this.panel3.Controls.Add(this.addFan);
            this.panel3.Controls.Add(this.fanTarifiTxt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.fanNomiTxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 144);
            this.panel3.TabIndex = 4;
            // 
            // deleteFan
            // 
            this.deleteFan.BackColor = System.Drawing.Color.Red;
            this.deleteFan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteFan.Location = new System.Drawing.Point(572, 83);
            this.deleteFan.Name = "deleteFan";
            this.deleteFan.Size = new System.Drawing.Size(115, 36);
            this.deleteFan.TabIndex = 15;
            this.deleteFan.Text = "O\'chirish";
            this.deleteFan.UseVisualStyleBackColor = false;
            this.deleteFan.Click += new System.EventHandler(this.deleteFan_Click);
            // 
            // editFan
            // 
            this.editFan.BackColor = System.Drawing.Color.PaleGreen;
            this.editFan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editFan.Location = new System.Drawing.Point(725, 83);
            this.editFan.Name = "editFan";
            this.editFan.Size = new System.Drawing.Size(115, 36);
            this.editFan.TabIndex = 14;
            this.editFan.Text = "Tahrirlash";
            this.editFan.UseVisualStyleBackColor = false;
            this.editFan.Click += new System.EventHandler(this.editFan_Click);
            // 
            // addFan
            // 
            this.addFan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addFan.Location = new System.Drawing.Point(867, 83);
            this.addFan.Name = "addFan";
            this.addFan.Size = new System.Drawing.Size(115, 36);
            this.addFan.TabIndex = 13;
            this.addFan.Text = "Qo\'shish";
            this.addFan.UseVisualStyleBackColor = false;
            this.addFan.Click += new System.EventHandler(this.addFan_Click);
            // 
            // fanTarifiTxt
            // 
            this.fanTarifiTxt.Location = new System.Drawing.Point(16, 89);
            this.fanTarifiTxt.Name = "fanTarifiTxt";
            this.fanTarifiTxt.Size = new System.Drawing.Size(348, 27);
            this.fanTarifiTxt.TabIndex = 5;
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
            // fanNomiTxt
            // 
            this.fanNomiTxt.Location = new System.Drawing.Point(16, 37);
            this.fanNomiTxt.Name = "fanNomiTxt";
            this.fanNomiTxt.Size = new System.Drawing.Size(348, 27);
            this.fanNomiTxt.TabIndex = 3;
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
            // fanData
            // 
            this.fanData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fanData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.fanData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fanData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fanData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fanData.Location = new System.Drawing.Point(0, 0);
            this.fanData.Name = "fanData";
            this.fanData.Size = new System.Drawing.Size(995, 554);
            this.fanData.TabIndex = 1;
            // 
            // Fanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 742);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fanlar";
            this.Text = "Fanlar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deleteFan;
        private System.Windows.Forms.Button editFan;
        private System.Windows.Forms.Button addFan;
        private System.Windows.Forms.TextBox fanTarifiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fanNomiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView fanData;
    }
}