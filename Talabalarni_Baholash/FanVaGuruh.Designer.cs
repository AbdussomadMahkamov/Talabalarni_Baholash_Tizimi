
namespace Talabalarni_Baholash
{
    partial class FanVaGuruh
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
            this.connectGroupSubject = new System.Windows.Forms.Button();
            this.fanCombo = new System.Windows.Forms.ComboBox();
            this.guruhCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fanVaGuruhData = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanVaGuruhData)).BeginInit();
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
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fan va Guruhlar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectGroupSubject);
            this.panel1.Controls.Add(this.fanCombo);
            this.panel1.Controls.Add(this.guruhCombo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 86);
            this.panel1.TabIndex = 5;
            // 
            // connectGroupSubject
            // 
            this.connectGroupSubject.BackColor = System.Drawing.SystemColors.HotTrack;
            this.connectGroupSubject.Location = new System.Drawing.Point(812, 27);
            this.connectGroupSubject.Name = "connectGroupSubject";
            this.connectGroupSubject.Size = new System.Drawing.Size(115, 36);
            this.connectGroupSubject.TabIndex = 11;
            this.connectGroupSubject.Text = "Qo\'shish";
            this.connectGroupSubject.UseVisualStyleBackColor = false;
            this.connectGroupSubject.Click += new System.EventHandler(this.connectGroupSubject_Click);
            // 
            // fanCombo
            // 
            this.fanCombo.FormattingEnabled = true;
            this.fanCombo.Location = new System.Drawing.Point(391, 32);
            this.fanCombo.Name = "fanCombo";
            this.fanCombo.Size = new System.Drawing.Size(300, 31);
            this.fanCombo.TabIndex = 4;
            // 
            // guruhCombo
            // 
            this.guruhCombo.FormattingEnabled = true;
            this.guruhCombo.Location = new System.Drawing.Point(46, 32);
            this.guruhCombo.Name = "guruhCombo";
            this.guruhCombo.Size = new System.Drawing.Size(300, 31);
            this.guruhCombo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fanni tanlash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guruhni tanlash";
            // 
            // fanVaGuruhData
            // 
            this.fanVaGuruhData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fanVaGuruhData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.fanVaGuruhData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fanVaGuruhData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fanVaGuruhData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fanVaGuruhData.Location = new System.Drawing.Point(0, 130);
            this.fanVaGuruhData.Name = "fanVaGuruhData";
            this.fanVaGuruhData.Size = new System.Drawing.Size(1011, 651);
            this.fanVaGuruhData.TabIndex = 6;
            // 
            // FanVaGuruh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 781);
            this.Controls.Add(this.fanVaGuruhData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FanVaGuruh";
            this.Text = "FanVaGuruh";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanVaGuruhData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox fanCombo;
        private System.Windows.Forms.ComboBox guruhCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectGroupSubject;
        private System.Windows.Forms.DataGridView fanVaGuruhData;
    }
}