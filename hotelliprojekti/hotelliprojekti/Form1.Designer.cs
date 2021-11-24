namespace hotelliprojekti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLB = new System.Windows.Forms.Label();
            this.loginBT = new System.Windows.Forms.Button();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLB
            // 
            this.loginLB.AutoSize = true;
            this.loginLB.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLB.Location = new System.Drawing.Point(157, 41);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(178, 32);
            this.loginLB.TabIndex = 0;
            this.loginLB.Text = "Kirjaudu sisään";
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(195, 230);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(102, 46);
            this.loginBT.TabIndex = 1;
            this.loginBT.Text = "Kirjaudu";
            this.loginBT.UseVisualStyleBackColor = true;
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(172, 125);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(153, 23);
            this.kayttajaTB.TabIndex = 2;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(172, 174);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(153, 23);
            this.salasanaTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salasana:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(503, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salasanaTB);
            this.Controls.Add(this.kayttajaTB);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.loginLB);
            this.Name = "Form1";
            this.Text = "Kirjaudu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLB;
        private Button loginBT;
        private TextBox kayttajaTB;
        private TextBox salasanaTB;
        private Label label1;
        private Label label2;
    }
}