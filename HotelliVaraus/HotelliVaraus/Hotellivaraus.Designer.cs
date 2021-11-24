namespace HotelliVaraus
{
    partial class Kirjautumisikkuna
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
            this.LoginPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KayttajatunnusLB = new System.Windows.Forms.Label();
            this.KayttajatunnusTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KirjauduBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPic
            // 
            this.LoginPic.Image = global::HotelliVaraus.Properties.Resources.user1;
            this.LoginPic.Location = new System.Drawing.Point(155, 22);
            this.LoginPic.Name = "LoginPic";
            this.LoginPic.Size = new System.Drawing.Size(160, 160);
            this.LoginPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPic.TabIndex = 0;
            this.LoginPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.OtsikkoLB);
            this.panel1.Location = new System.Drawing.Point(12, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 62);
            this.panel1.TabIndex = 1;
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.ForeColor = System.Drawing.Color.White;
            this.OtsikkoLB.Location = new System.Drawing.Point(82, 10);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(274, 42);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Kirjaudu sisään";
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KirjauduBT);
            this.groupBox1.Controls.Add(this.SalasanaLB);
            this.groupBox1.Controls.Add(this.SalasanaTB);
            this.groupBox1.Controls.Add(this.KayttajatunnusTB);
            this.groupBox1.Controls.Add(this.KayttajatunnusLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // KayttajatunnusLB
            // 
            this.KayttajatunnusLB.AutoSize = true;
            this.KayttajatunnusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatunnusLB.ForeColor = System.Drawing.Color.White;
            this.KayttajatunnusLB.Location = new System.Drawing.Point(7, 47);
            this.KayttajatunnusLB.Name = "KayttajatunnusLB";
            this.KayttajatunnusLB.Size = new System.Drawing.Size(161, 25);
            this.KayttajatunnusLB.TabIndex = 0;
            this.KayttajatunnusLB.Text = "Käyttäjätunnus:";
            // 
            // KayttajatunnusTB
            // 
            this.KayttajatunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajatunnusTB.Location = new System.Drawing.Point(181, 48);
            this.KayttajatunnusTB.Name = "KayttajatunnusTB";
            this.KayttajatunnusTB.Size = new System.Drawing.Size(267, 26);
            this.KayttajatunnusTB.TabIndex = 1;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(181, 110);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(267, 26);
            this.SalasanaTB.TabIndex = 2;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaLB.ForeColor = System.Drawing.Color.White;
            this.SalasanaLB.Location = new System.Drawing.Point(7, 110);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(108, 25);
            this.SalasanaLB.TabIndex = 3;
            this.SalasanaLB.Text = "Salasana:";
            this.SalasanaLB.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.BackColor = System.Drawing.Color.MediumBlue;
            this.KirjauduBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.ForeColor = System.Drawing.Color.White;
            this.KirjauduBT.Location = new System.Drawing.Point(90, 208);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(267, 59);
            this.KirjauduBT.TabIndex = 4;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = false;
            // 
            // Kirjautumisikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(478, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginPic);
            this.Name = "Kirjautumisikkuna";
            this.Text = "Hotelli varaus";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox KayttajatunnusTB;
        private System.Windows.Forms.Label KayttajatunnusLB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Button KirjauduBT;
    }
}

