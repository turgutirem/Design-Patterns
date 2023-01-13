
namespace TranslateApp
{
    partial class Form1
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
            this.lblIngilizce = new System.Windows.Forms.Label();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.tbxIngilizce = new System.Windows.Forms.TextBox();
            this.tbxTurkce = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblIngilizce
            // 
            this.lblIngilizce.AutoSize = true;
            this.lblIngilizce.Location = new System.Drawing.Point(39, 44);
            this.lblIngilizce.Name = "lblIngilizce";
            this.lblIngilizce.Size = new System.Drawing.Size(62, 17);
            this.lblIngilizce.TabIndex = 0;
            this.lblIngilizce.Text = "İngilizce:";
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Location = new System.Drawing.Point(306, 44);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(56, 17);
            this.lblTurkce.TabIndex = 1;
            this.lblTurkce.Text = "Türkçe:";
            // 
            // tbxIngilizce
            // 
            this.tbxIngilizce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxIngilizce.Location = new System.Drawing.Point(107, 44);
            this.tbxIngilizce.Name = "tbxIngilizce";
            this.tbxIngilizce.Size = new System.Drawing.Size(158, 22);
            this.tbxIngilizce.TabIndex = 2;
            this.tbxIngilizce.TextChanged += new System.EventHandler(this.tbxIngilizce_TextChanged);
            // 
            // tbxTurkce
            // 
            this.tbxTurkce.Location = new System.Drawing.Point(368, 44);
            this.tbxTurkce.Name = "tbxTurkce";
            this.tbxTurkce.Size = new System.Drawing.Size(151, 22);
            this.tbxTurkce.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(42, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 164);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 281);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbxTurkce);
            this.Controls.Add(this.tbxIngilizce);
            this.Controls.Add(this.lblTurkce);
            this.Controls.Add(this.lblIngilizce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngilizce;
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.TextBox tbxIngilizce;
        private System.Windows.Forms.TextBox tbxTurkce;
        private System.Windows.Forms.ListBox listBox1;
    }
}

