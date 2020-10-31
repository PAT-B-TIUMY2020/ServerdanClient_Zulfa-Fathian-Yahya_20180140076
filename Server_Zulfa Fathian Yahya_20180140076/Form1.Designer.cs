namespace Server_Zulfa_Fathian_Yahya_20180140076
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
            this.on = new System.Windows.Forms.Label();
            this.off = new System.Windows.Forms.Label();
            this.offklik = new System.Windows.Forms.Label();
            this.onklik = new System.Windows.Forms.Label();
            this.btnon = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server ";
            // 
            // on
            // 
            this.on.AutoSize = true;
            this.on.Location = new System.Drawing.Point(348, 132);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(29, 17);
            this.on.TabIndex = 2;
            this.on.Text = "ON";
            // 
            // off
            // 
            this.off.AutoSize = true;
            this.off.Location = new System.Drawing.Point(348, 132);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(35, 17);
            this.off.TabIndex = 3;
            this.off.Text = "OFF";
            // 
            // offklik
            // 
            this.offklik.AutoSize = true;
            this.offklik.Location = new System.Drawing.Point(288, 172);
            this.offklik.Name = "offklik";
            this.offklik.Size = new System.Drawing.Size(237, 17);
            this.offklik.TabIndex = 4;
            this.offklik.Text = "Klik ON untuk menghidupkan Server";
            // 
            // onklik
            // 
            this.onklik.AutoSize = true;
            this.onklik.Location = new System.Drawing.Point(288, 172);
            this.onklik.Name = "onklik";
            this.onklik.Size = new System.Drawing.Size(218, 17);
            this.onklik.TabIndex = 5;
            this.onklik.Text = "Klik OFF untuk mematikan Server";
            // 
            // btnon
            // 
            this.btnon.Location = new System.Drawing.Point(267, 241);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(75, 23);
            this.btnon.TabIndex = 6;
            this.btnon.Text = "ON";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // btnoff
            // 
            this.btnoff.Location = new System.Drawing.Point(395, 241);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(75, 23);
            this.btnoff.TabIndex = 7;
            this.btnoff.Text = "OFF";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnoff);
            this.Controls.Add(this.btnon);
            this.Controls.Add(this.onklik);
            this.Controls.Add(this.offklik);
            this.Controls.Add(this.off);
            this.Controls.Add(this.on);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label on;
        private System.Windows.Forms.Label off;
        private System.Windows.Forms.Label offklik;
        private System.Windows.Forms.Label onklik;
        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Button btnoff;
    }
}

