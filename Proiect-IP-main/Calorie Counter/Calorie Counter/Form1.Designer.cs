namespace Calorie_Counter
{
    partial class Meniu
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSetari = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.titlu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(441, 158);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 54);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSetari
            // 
            this.btnSetari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetari.Location = new System.Drawing.Point(441, 236);
            this.btnSetari.Name = "btnSetari";
            this.btnSetari.Size = new System.Drawing.Size(185, 54);
            this.btnSetari.TabIndex = 1;
            this.btnSetari.Text = "Setari";
            this.btnSetari.UseVisualStyleBackColor = true;
            this.btnSetari.Click += new System.EventHandler(this.btnSetari_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(441, 314);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(185, 54);
            this.btnIesire.TabIndex = 2;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.Location = new System.Drawing.Point(386, 68);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(294, 42);
            this.titlu.TabIndex = 3;
            this.titlu.Text = "Calorie Counter";
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calorie_Counter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnSetari);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Meniu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSetari;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label titlu;
    }
}

