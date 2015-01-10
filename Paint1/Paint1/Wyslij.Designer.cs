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
            this.wyslijB.Location = new System.Drawing.Point(53, 145);
            this.wyslijB.Name = "wyslijB";
            this.wyslijB.Size = new System.Drawing.Size(75, 23);
            this.wyslijB.TabIndex = 2;
            this.wyslijB.Text = "Wyslij";
            this.wyslijB.UseVisualStyleBackColor = true;
            this.wyslijB.Click += new System.EventHandler(this.wyslijB_Click);
            // 
            // anulujWyslanie
            // 
            this.anulujWyslanie.Location = new System.Drawing.Point(150, 145);
            this.anulujWyslanie.Name = "anulujWyslanie";
            this.anulujWyslanie.Size = new System.Drawing.Size(75, 23);
            this.anulujWyslanie.TabIndex = 3;
            this.anulujWyslanie.Text = "Anuluj";
            this.anulujWyslanie.UseVisualStyleBackColor = true;
            this.anulujWyslanie.Click += new System.EventHandler(this.anulujWyslanie_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(53, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stan";
            // 
            // Wyslij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.anulujWyslanie);
            this.Controls.Add(this.wyslijB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortChB);
            this.Name = "Wyslij";
            this.Text = "Wyslij";
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
    }
}