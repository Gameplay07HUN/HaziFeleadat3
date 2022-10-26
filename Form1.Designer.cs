namespace WindowsFormsApp1CUCC
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
            this.textBox1_nev = new System.Windows.Forms.TextBox();
            this.numericUpDown1_azonosito = new System.Windows.Forms.NumericUpDown();
            this.label_azonosito = new System.Windows.Forms.Label();
            this.label_nev = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.nyelvek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mikor_szuletett = new System.Windows.Forms.Label();
            this.Bekuldes_gomb = new System.Windows.Forms.Button();
            this.telepules = new System.Windows.Forms.ComboBox();
            this.hol_szuletett = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_azonosito)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_nev
            // 
            this.textBox1_nev.Location = new System.Drawing.Point(29, 98);
            this.textBox1_nev.Name = "textBox1_nev";
            this.textBox1_nev.Size = new System.Drawing.Size(100, 20);
            this.textBox1_nev.TabIndex = 0;
            // 
            // numericUpDown1_azonosito
            // 
            this.numericUpDown1_azonosito.Location = new System.Drawing.Point(29, 47);
            this.numericUpDown1_azonosito.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1_azonosito.Name = "numericUpDown1_azonosito";
            this.numericUpDown1_azonosito.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1_azonosito.TabIndex = 1;
            // 
            // label_azonosito
            // 
            this.label_azonosito.AutoSize = true;
            this.label_azonosito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_azonosito.Location = new System.Drawing.Point(24, 19);
            this.label_azonosito.Name = "label_azonosito";
            this.label_azonosito.Size = new System.Drawing.Size(113, 25);
            this.label_azonosito.TabIndex = 2;
            this.label_azonosito.Text = "Azonosító ";
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nev.Location = new System.Drawing.Point(24, 70);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(50, 25);
            this.label_nev.TabIndex = 3;
            this.label_nev.Text = "Név";
            // 
            // Datum
            // 
            this.Datum.Location = new System.Drawing.Point(29, 203);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(200, 20);
            this.Datum.TabIndex = 4;
            // 
            // nyelvek
            // 
            this.nyelvek.FormattingEnabled = true;
            this.nyelvek.Items.AddRange(new object[] {
            "angol",
            "német",
            "francia",
            "olasz"});
            this.nyelvek.Location = new System.Drawing.Point(29, 149);
            this.nyelvek.Name = "nyelvek";
            this.nyelvek.Size = new System.Drawing.Size(140, 21);
            this.nyelvek.TabIndex = 5;
            this.nyelvek.Text = "angol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Milyen nyelven akar beszélni?";
            // 
            // mikor_szuletett
            // 
            this.mikor_szuletett.AutoSize = true;
            this.mikor_szuletett.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mikor_szuletett.Location = new System.Drawing.Point(29, 175);
            this.mikor_szuletett.Name = "mikor_szuletett";
            this.mikor_szuletett.Size = new System.Drawing.Size(164, 25);
            this.mikor_szuletett.TabIndex = 7;
            this.mikor_szuletett.Text = "Mikor született?";
            // 
            // Bekuldes_gomb
            // 
            this.Bekuldes_gomb.Location = new System.Drawing.Point(29, 284);
            this.Bekuldes_gomb.Name = "Bekuldes_gomb";
            this.Bekuldes_gomb.Size = new System.Drawing.Size(75, 23);
            this.Bekuldes_gomb.TabIndex = 8;
            this.Bekuldes_gomb.Text = "Beküldes";
            this.Bekuldes_gomb.UseVisualStyleBackColor = true;
            this.Bekuldes_gomb.Click += new System.EventHandler(this.Bekuldes_gomb_Click);
            // 
            // telepules
            // 
            this.telepules.FormattingEnabled = true;
            this.telepules.Items.AddRange(new object[] {
            "Debrecen",
            "Budapest",
            "Szeged",
            "Győr",
            "Sopron",
            "Sajókápolna",
            "Gyöngyös",
            "Gyöngyöspata"});
            this.telepules.Location = new System.Drawing.Point(29, 257);
            this.telepules.Name = "telepules";
            this.telepules.Size = new System.Drawing.Size(121, 21);
            this.telepules.TabIndex = 9;
            this.telepules.Text = "Debrecen";
            // 
            // hol_szuletett
            // 
            this.hol_szuletett.AutoSize = true;
            this.hol_szuletett.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hol_szuletett.Location = new System.Drawing.Point(29, 229);
            this.hol_szuletett.Name = "hol_szuletett";
            this.hol_szuletett.Size = new System.Drawing.Size(143, 25);
            this.hol_szuletett.TabIndex = 10;
            this.hol_szuletett.Text = "Hol született?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hol_szuletett);
            this.Controls.Add(this.telepules);
            this.Controls.Add(this.Bekuldes_gomb);
            this.Controls.Add(this.mikor_szuletett);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nyelvek);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.label_azonosito);
            this.Controls.Add(this.numericUpDown1_azonosito);
            this.Controls.Add(this.textBox1_nev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_azonosito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_nev;
        private System.Windows.Forms.NumericUpDown numericUpDown1_azonosito;
        private System.Windows.Forms.Label label_azonosito;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.ComboBox nyelvek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mikor_szuletett;
        private System.Windows.Forms.Button Bekuldes_gomb;
        private System.Windows.Forms.ComboBox telepules;
        private System.Windows.Forms.Label hol_szuletett;
    }
}

