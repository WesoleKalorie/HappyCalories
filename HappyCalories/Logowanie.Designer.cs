namespace HappyCalories
{
    partial class Logowanie
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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Haslo = new System.Windows.Forms.TextBox();
            this.button_zaloguj = new System.Windows.Forms.Button();
            this.label_zlehaslo = new System.Windows.Forms.Label();
            this.label_dorejestracji = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(-4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Happy Calories";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(170, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "© A.Mogielnicka, B.Szweda, K.Szyda";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.LightPink;
            this.label3.Location = new System.Drawing.Point(223, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightPink;
            this.label4.Location = new System.Drawing.Point(223, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "HASŁO";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Login.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Login.Location = new System.Drawing.Point(194, 193);
            this.textBox_Login.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(148, 19);
            this.textBox_Login.TabIndex = 4;
            // 
            // textBox_Haslo
            // 
            this.textBox_Haslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Haslo.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Haslo.Location = new System.Drawing.Point(194, 262);
            this.textBox_Haslo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Haslo.Name = "textBox_Haslo";
            this.textBox_Haslo.Size = new System.Drawing.Size(148, 19);
            this.textBox_Haslo.TabIndex = 5;
            // 
            // button_zaloguj
            // 
            this.button_zaloguj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_zaloguj.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_zaloguj.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zaloguj.ForeColor = System.Drawing.Color.LightPink;
            this.button_zaloguj.Location = new System.Drawing.Point(194, 312);
            this.button_zaloguj.Margin = new System.Windows.Forms.Padding(2);
            this.button_zaloguj.Name = "button_zaloguj";
            this.button_zaloguj.Size = new System.Drawing.Size(147, 62);
            this.button_zaloguj.TabIndex = 6;
            this.button_zaloguj.Text = "ZALOGUJ";
            this.button_zaloguj.UseVisualStyleBackColor = false;
            this.button_zaloguj.Click += new System.EventHandler(this.button_zaloguj_Click);
            // 
            // label_zlehaslo
            // 
            this.label_zlehaslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_zlehaslo.AutoSize = true;
            this.label_zlehaslo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zlehaslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_zlehaslo.Location = new System.Drawing.Point(151, 283);
            this.label_zlehaslo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_zlehaslo.Name = "label_zlehaslo";
            this.label_zlehaslo.Size = new System.Drawing.Size(245, 15);
            this.label_zlehaslo.TabIndex = 7;
            this.label_zlehaslo.Text = "!Złe hasło lub konto nie istnieje!";
            this.label_zlehaslo.Visible = false;
            // 
            // label_dorejestracji
            // 
            this.label_dorejestracji.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_dorejestracji.AutoSize = true;
            this.label_dorejestracji.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dorejestracji.ForeColor = System.Drawing.Color.LightPink;
            this.label_dorejestracji.Location = new System.Drawing.Point(140, 376);
            this.label_dorejestracji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_dorejestracji.Name = "label_dorejestracji";
            this.label_dorejestracji.Size = new System.Drawing.Size(280, 14);
            this.label_dorejestracji.TabIndex = 8;
            this.label_dorejestracji.Text = "↓Pierwszy raz z nami? Zarejestruj się ↓";
            this.label_dorejestracji.Click += new System.EventHandler(this.label_dorejestracji_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(588, 456);
            this.Controls.Add(this.label_dorejestracji);
            this.Controls.Add(this.label_zlehaslo);
            this.Controls.Add(this.button_zaloguj);
            this.Controls.Add(this.textBox_Haslo);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Haslo;
        private System.Windows.Forms.Button button_zaloguj;
        private System.Windows.Forms.Label label_zlehaslo;
        private System.Windows.Forms.Label label_dorejestracji;
    }
}