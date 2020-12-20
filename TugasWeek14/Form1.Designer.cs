
namespace TugasWeek14
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxnama = new System.Windows.Forms.TextBox();
            this.textBoxawal = new System.Windows.Forms.TextBox();
            this.textBoxakhir = new System.Windows.Forms.TextBox();
            this.buttoncvrt = new System.Windows.Forms.Button();
            this.labelout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menjadi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil:";
            // 
            // textBoxnama
            // 
            this.textBoxnama.Location = new System.Drawing.Point(152, 42);
            this.textBoxnama.Name = "textBoxnama";
            this.textBoxnama.Size = new System.Drawing.Size(198, 20);
            this.textBoxnama.TabIndex = 4;
            // 
            // textBoxawal
            // 
            this.textBoxawal.Location = new System.Drawing.Point(152, 78);
            this.textBoxawal.Name = "textBoxawal";
            this.textBoxawal.Size = new System.Drawing.Size(64, 20);
            this.textBoxawal.TabIndex = 5;
            // 
            // textBoxakhir
            // 
            this.textBoxakhir.Location = new System.Drawing.Point(282, 78);
            this.textBoxakhir.Name = "textBoxakhir";
            this.textBoxakhir.Size = new System.Drawing.Size(68, 20);
            this.textBoxakhir.TabIndex = 6;
            // 
            // buttoncvrt
            // 
            this.buttoncvrt.Location = new System.Drawing.Point(152, 114);
            this.buttoncvrt.Name = "buttoncvrt";
            this.buttoncvrt.Size = new System.Drawing.Size(198, 23);
            this.buttoncvrt.TabIndex = 7;
            this.buttoncvrt.Text = "Konversi!";
            this.buttoncvrt.UseVisualStyleBackColor = true;
            this.buttoncvrt.Click += new System.EventHandler(this.buttoncvrt_Click);
            // 
            // labelout
            // 
            this.labelout.AutoSize = true;
            this.labelout.Location = new System.Drawing.Point(149, 159);
            this.labelout.Name = "labelout";
            this.labelout.Size = new System.Drawing.Size(52, 13);
            this.labelout.TabIndex = 8;
            this.labelout.Text = "OUTPUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 203);
            this.Controls.Add(this.labelout);
            this.Controls.Add(this.buttoncvrt);
            this.Controls.Add(this.textBoxakhir);
            this.Controls.Add(this.textBoxawal);
            this.Controls.Add(this.textBoxnama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxnama;
        private System.Windows.Forms.TextBox textBoxawal;
        private System.Windows.Forms.TextBox textBoxakhir;
        private System.Windows.Forms.Button buttoncvrt;
        private System.Windows.Forms.Label labelout;
    }
}

