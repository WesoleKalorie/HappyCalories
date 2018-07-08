namespace HappyCalories
{
    partial class Dieta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dieta));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ŚNIADANIE", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("OBIAD", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("DESER", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("KOLACJA", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Jajecznica",
            "562"}, -1, System.Drawing.SystemColors.ControlDarkDark, System.Drawing.Color.Empty, new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kalafiorowa",
            "254"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Schabowy",
            "489"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sernik",
            "150"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sałatka grecka",
            "323"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "nazwa_składnika", System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.Window, new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "ile_składnika", System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.Window, new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238))))}, -1);
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_dania = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader_nazwadania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_kalorycznoscpor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_nazwadania = new System.Windows.Forms.Label();
            this.listView_produkty = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader_produkt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_gramy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_reload = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(336, 63);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_logo.TabIndex = 4;
            this.pictureBox_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(275, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "TWOJA DIETA NA DZIŚ!";
            // 
            // listView_dania
            // 
            this.listView_dania.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_dania.BackgroundImage")));
            this.listView_dania.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_dania.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_nazwadania,
            this.columnHeader_kalorycznoscpor});
            this.listView_dania.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView_dania.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView_dania.FullRowSelect = true;
            listViewGroup1.Header = "ŚNIADANIE";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewGroup_sniadanie";
            listViewGroup2.Header = "OBIAD";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "listViewGroup_obiad";
            listViewGroup3.Header = "DESER";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "listViewGroup_deser";
            listViewGroup4.Header = "KOLACJA";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "listViewGroup_kolacja";
            this.listView_dania.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup3;
            listViewItem5.Group = listViewGroup4;
            this.listView_dania.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView_dania.Location = new System.Drawing.Point(9, 186);
            this.listView_dania.Margin = new System.Windows.Forms.Padding(0);
            this.listView_dania.MultiSelect = false;
            this.listView_dania.Name = "listView_dania";
            this.listView_dania.Size = new System.Drawing.Size(327, 284);
            this.listView_dania.TabIndex = 6;
            this.listView_dania.UseCompatibleStateImageBehavior = false;
            this.listView_dania.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(896, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "proponowana dieta to zestaw pięciu posiłków których kompozycja pokryje twoje dzie" +
    "nne zapotrzebowanie kaloryczne";
            // 
            // columnHeader_nazwadania
            // 
            this.columnHeader_nazwadania.Text = "Nazwa";
            this.columnHeader_nazwadania.Width = 179;
            // 
            // columnHeader_kalorycznoscpor
            // 
            this.columnHeader_kalorycznoscpor.Text = "kcal/porcja";
            this.columnHeader_kalorycznoscpor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_kalorycznoscpor.Width = 123;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 417);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label_nazwadania
            // 
            this.label_nazwadania.AutoSize = true;
            this.label_nazwadania.ForeColor = System.Drawing.Color.LightPink;
            this.label_nazwadania.Image = ((System.Drawing.Image)(resources.GetObject("label_nazwadania.Image")));
            this.label_nazwadania.Location = new System.Drawing.Point(450, 158);
            this.label_nazwadania.Name = "label_nazwadania";
            this.label_nazwadania.Size = new System.Drawing.Size(229, 20);
            this.label_nazwadania.TabIndex = 9;
            this.label_nazwadania.Text = "TU MA BYĆ NAZWA DANIA:";
            // 
            // listView_produkty
            // 
            this.listView_produkty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView_produkty.BackgroundImage")));
            this.listView_produkty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_produkty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_produkt,
            this.columnHeader_gramy});
            this.listView_produkty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView_produkty.FullRowSelect = true;
            this.listView_produkty.GridLines = true;
            this.listView_produkty.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.listView_produkty.Location = new System.Drawing.Point(339, 186);
            this.listView_produkty.MultiSelect = false;
            this.listView_produkty.Name = "listView_produkty";
            this.listView_produkty.Size = new System.Drawing.Size(431, 355);
            this.listView_produkty.TabIndex = 10;
            this.listView_produkty.UseCompatibleStateImageBehavior = false;
            this.listView_produkty.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightPink;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(84, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "WYBIERZ DANIE:";
            // 
            // columnHeader_produkt
            // 
            this.columnHeader_produkt.Text = "Produkt";
            this.columnHeader_produkt.Width = 282;
            // 
            // columnHeader_gramy
            // 
            this.columnHeader_gramy.Text = "Gramatura";
            this.columnHeader_gramy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_gramy.Width = 148;
            // 
            // button_reload
            // 
            this.button_reload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_reload.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_reload.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reload.ForeColor = System.Drawing.Color.LightPink;
            this.button_reload.Location = new System.Drawing.Point(9, 460);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(154, 81);
            this.button_reload.TabIndex = 41;
            this.button_reload.Text = "NOWY\r\nZESTAW";
            this.button_reload.UseVisualStyleBackColor = false;
            // 
            // button_back
            // 
            this.button_back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_back.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_back.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.ForeColor = System.Drawing.Color.LightPink;
            this.button_back.Location = new System.Drawing.Point(182, 460);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(154, 81);
            this.button_back.TabIndex = 42;
            this.button_back.Text = "WRÓĆ";
            this.button_back.UseVisualStyleBackColor = false;
            // 
            // Dieta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_produkty);
            this.Controls.Add(this.label_nazwadania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_dania);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Location = new System.Drawing.Point(100, 2000);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Dieta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dieta";
            this.Load += new System.EventHandler(this.Dieta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_dania;
        private System.Windows.Forms.ColumnHeader columnHeader_nazwadania;
        private System.Windows.Forms.ColumnHeader columnHeader_kalorycznoscpor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_nazwadania;
        private System.Windows.Forms.ListView listView_produkty;
        private System.Windows.Forms.ColumnHeader columnHeader_produkt;
        private System.Windows.Forms.ColumnHeader columnHeader_gramy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Button button_back;
    }
}