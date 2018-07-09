namespace HappyCalories
{
    partial class KalkulatorKalorii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KalkulatorKalorii));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.listView_listaproduktow = new System.Windows.Forms.ListView();
            this.columnHeader_nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_kalorycznosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_produkt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_gramatura = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label_kalprod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gramatura)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(336, 63);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_logo.TabIndex = 3;
            this.pictureBox_logo.TabStop = false;
            // 
            // listView_listaproduktow
            // 
            this.listView_listaproduktow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_listaproduktow.BackgroundImage")));
            this.listView_listaproduktow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_listaproduktow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_nazwa,
            this.columnHeader_kalorycznosc});
            this.listView_listaproduktow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView_listaproduktow.FullRowSelect = true;
            this.listView_listaproduktow.GridLines = true;
            this.listView_listaproduktow.Location = new System.Drawing.Point(15, 90);
            this.listView_listaproduktow.MultiSelect = false;
            this.listView_listaproduktow.Name = "listView_listaproduktow";
            this.listView_listaproduktow.Size = new System.Drawing.Size(419, 451);
            this.listView_listaproduktow.TabIndex = 4;
            this.listView_listaproduktow.UseCompatibleStateImageBehavior = false;
            this.listView_listaproduktow.View = System.Windows.Forms.View.Details;
            this.listView_listaproduktow.SelectedIndexChanged += new System.EventHandler(this.listView_listaproduktow_SelectedIndexChanged);
            // 
            // columnHeader_nazwa
            // 
            this.columnHeader_nazwa.Text = "Nazwa";
            this.columnHeader_nazwa.Width = 296;
            // 
            // columnHeader_kalorycznosc
            // 
            this.columnHeader_kalorycznosc.Text = "kcal/100g";
            this.columnHeader_kalorycznosc.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(480, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "WYBIERZ PRODUKT Z LISTY\r\nLUB\r\nWYSZUKAJ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_produkt
            // 
            this.textBox_produkt.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_produkt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_produkt.Location = new System.Drawing.Point(460, 162);
            this.textBox_produkt.Name = "textBox_produkt";
            this.textBox_produkt.Size = new System.Drawing.Size(282, 23);
            this.textBox_produkt.TabIndex = 6;
            this.textBox_produkt.TextChanged += new System.EventHandler(this.textBox_produkt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.LightPink;
            this.label2.Location = new System.Drawing.Point(551, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "GRAMATURA\r\nPRODUKTU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_gramatura
            // 
            this.numericUpDown_gramatura.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_gramatura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown_gramatura.Location = new System.Drawing.Point(546, 283);
            this.numericUpDown_gramatura.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_gramatura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_gramatura.Name = "numericUpDown_gramatura";
            this.numericUpDown_gramatura.Size = new System.Drawing.Size(114, 23);
            this.numericUpDown_gramatura.TabIndex = 8;
            this.numericUpDown_gramatura.ThousandsSeparator = true;
            this.numericUpDown_gramatura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.LightPink;
            this.label3.Location = new System.Drawing.Point(521, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "OBLICZONE KALORIE";
            // 
            // label_kalprod
            // 
            this.label_kalprod.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_kalprod.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_kalprod.Image = ((System.Drawing.Image)(resources.GetObject("label_kalprod.Image")));
            this.label_kalprod.Location = new System.Drawing.Point(502, 381);
            this.label_kalprod.Name = "label_kalprod";
            this.label_kalprod.Size = new System.Drawing.Size(214, 38);
            this.label_kalprod.TabIndex = 10;
            this.label_kalprod.Text = "2483,5";
            this.label_kalprod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(666, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "g";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(721, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "kcal";
            // 
            // button_back
            // 
            this.button_back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_back.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_back.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.ForeColor = System.Drawing.Color.LightPink;
            this.button_back.Location = new System.Drawing.Point(506, 460);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(215, 81);
            this.button_back.TabIndex = 40;
            this.button_back.Text = "WRÓĆ";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // KalkulatorKalorii
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_kalprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_gramatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_produkt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_listaproduktow);
            this.Controls.Add(this.pictureBox_logo);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "KalkulatorKalorii";
            this.Text = "KalkulatorKalorii";
            this.Load += new System.EventHandler(this.KalkulatorKalorii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gramatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.ListView listView_listaproduktow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_produkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_gramatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_kalprod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ColumnHeader columnHeader_nazwa;
        private System.Windows.Forms.ColumnHeader columnHeader_kalorycznosc;
    }
}