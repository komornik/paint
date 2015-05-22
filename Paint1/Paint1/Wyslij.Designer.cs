namespace Paint
{
    partial class Wyslij
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
            this.PortChB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wyslijB = new System.Windows.Forms.Button();
            this.anulujWyslanie = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rozmiar_Y = new System.Windows.Forms.TextBox();
            this.rozmiar_X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortChB
            // 
            this.PortChB.FormattingEnabled = true;
            this.PortChB.Location = new System.Drawing.Point(90, 42);
            this.PortChB.Name = "PortChB";
            this.PortChB.Size = new System.Drawing.Size(121, 21);
            this.PortChB.TabIndex = 0;
            this.PortChB.SelectedValueChanged += new System.EventHandler(this.PortChB_SelectedValueChanged);
            this.PortChB.Click += new System.EventHandler(this.PortChB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // wyslijB
            // 
            this.wyslijB.Location = new System.Drawing.Point(18, 224);
            this.wyslijB.Name = "wyslijB";
            this.wyslijB.Size = new System.Drawing.Size(75, 23);
            this.wyslijB.TabIndex = 2;
            this.wyslijB.Text = "Wyslij";
            this.wyslijB.UseVisualStyleBackColor = true;
            this.wyslijB.Click += new System.EventHandler(this.wyslijB_Click);
            // 
            // anulujWyslanie
            // 
            this.anulujWyslanie.Location = new System.Drawing.Point(115, 224);
            this.anulujWyslanie.Name = "anulujWyslanie";
            this.anulujWyslanie.Size = new System.Drawing.Size(75, 23);
            this.anulujWyslanie.TabIndex = 3;
            this.anulujWyslanie.Text = "Anuluj";
            this.anulujWyslanie.UseVisualStyleBackColor = true;
            this.anulujWyslanie.Click += new System.EventHandler(this.anulujWyslanie_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 283);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rozmiar_Y);
            this.groupBox1.Controls.Add(this.rozmiar_X);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rozmiar Tablicy";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rozmiar_Y
            // 
            this.rozmiar_Y.Location = new System.Drawing.Point(34, 69);
            this.rozmiar_Y.Name = "rozmiar_Y";
            this.rozmiar_Y.Size = new System.Drawing.Size(100, 20);
            this.rozmiar_Y.TabIndex = 3;
            // 
            // rozmiar_X
            // 
            this.rozmiar_X.Location = new System.Drawing.Point(34, 33);
            this.rozmiar_X.Name = "rozmiar_X";
            this.rozmiar_X.Size = new System.Drawing.Size(100, 20);
            this.rozmiar_X.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pauza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Wypełnij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Wyslij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 347);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.anulujWyslanie);
            this.Controls.Add(this.wyslijB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortChB);
            this.Name = "Wyslij";
            this.Text = "Wyslij";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortChB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wyslijB;
        private System.Windows.Forms.Button anulujWyslanie;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rozmiar_Y;
        private System.Windows.Forms.TextBox rozmiar_X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}