namespace Paint
{
    partial class opcjeTekstu
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
            this.OK = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rodzajCzcionki = new System.Windows.Forms.ComboBox();
            this.styl = new System.Windows.Forms.ComboBox();
            this.wielkosc = new System.Windows.Forms.ComboBox();
            this.kolor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kolor)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(81, 307);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OK_MouseClick);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(184, 307);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 1;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(300, 100);
            this.textBox1.TabIndex = 2;
            // 
            // rodzajCzcionki
            // 
            this.rodzajCzcionki.FormattingEnabled = true;
            this.rodzajCzcionki.Location = new System.Drawing.Point(43, 35);
            this.rodzajCzcionki.Name = "rodzajCzcionki";
            this.rodzajCzcionki.Size = new System.Drawing.Size(140, 21);
            this.rodzajCzcionki.TabIndex = 3;
            this.rodzajCzcionki.SelectedIndexChanged += new System.EventHandler(this.rodzajCzcionki_SelectedIndexChanged);
            // 
            // styl
            // 
            this.styl.FormattingEnabled = true;
            this.styl.Location = new System.Drawing.Point(221, 35);
            this.styl.Name = "styl";
            this.styl.Size = new System.Drawing.Size(121, 21);
            this.styl.TabIndex = 4;
            this.styl.SelectedIndexChanged += new System.EventHandler(this.styl_SelectedIndexChanged);
            // 
            // wielkosc
            // 
            this.wielkosc.FormattingEnabled = true;
            this.wielkosc.Location = new System.Drawing.Point(43, 80);
            this.wielkosc.Name = "wielkosc";
            this.wielkosc.Size = new System.Drawing.Size(48, 21);
            this.wielkosc.TabIndex = 5;
            this.wielkosc.SelectedIndexChanged += new System.EventHandler(this.wielkosc_SelectedIndexChanged);
            // 
            // kolor
            // 
            this.kolor.BackColor = System.Drawing.Color.Black;
            this.kolor.Location = new System.Drawing.Point(169, 83);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(17, 17);
            this.kolor.TabIndex = 6;
            this.kolor.TabStop = false;
            this.kolor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kolor_MouseClick);
            // 
            // opcjeTekstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 342);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.wielkosc);
            this.Controls.Add(this.styl);
            this.Controls.Add(this.rodzajCzcionki);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.OK);
            this.Name = "opcjeTekstu";
            this.Text = "opcjeTekstu";
            this.Load += new System.EventHandler(this.opcjeTekstu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox rodzajCzcionki;
        private System.Windows.Forms.ComboBox styl;
        private System.Windows.Forms.ComboBox wielkosc;
        private System.Windows.Forms.PictureBox kolor;
    }
}