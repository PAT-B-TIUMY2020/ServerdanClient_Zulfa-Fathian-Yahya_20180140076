namespace ServerdanClient_Zulfa_Fathian_Yahya_20180140076
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Label();
            this.kurang = new System.Windows.Forms.Label();
            this.kali = new System.Windows.Forms.Label();
            this.bagi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Angka 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angka 2";
            // 
            // tambah
            // 
            this.tambah.AutoSize = true;
            this.tambah.Location = new System.Drawing.Point(382, 62);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(135, 17);
            this.tambah.TabIndex = 4;
            this.tambah.Text = "Hasil Penambahan :";
            // 
            // kurang
            // 
            this.kurang.AutoSize = true;
            this.kurang.Location = new System.Drawing.Point(382, 113);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(137, 17);
            this.kurang.TabIndex = 5;
            this.kurang.Text = "Hasil Pengurangan :";
            // 
            // kali
            // 
            this.kali.AutoSize = true;
            this.kali.Location = new System.Drawing.Point(382, 170);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(110, 17);
            this.kali.TabIndex = 6;
            this.kali.Text = "Hasil Perkalian :";
            // 
            // bagi
            // 
            this.bagi.AutoSize = true;
            this.bagi.Location = new System.Drawing.Point(382, 223);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(122, 17);
            this.bagi.TabIndex = 7;
            this.bagi.Text = "Hasil Pembagian :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hasil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tambah;
        private System.Windows.Forms.Label kurang;
        private System.Windows.Forms.Label kali;
        private System.Windows.Forms.Label bagi;
        private System.Windows.Forms.Button button1;
    }
}

