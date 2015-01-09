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
            this.SuspendLayout();
            // 
            // PortChB
            // 
            this.PortChB.FormattingEnabled = true;
            this.PortChB.Location = new System.Drawing.Point(122, 42);
            this.PortChB.Name = "PortChB";
            this.PortChB.Size = new System.Drawing.Size(121, 21);
            this.PortChB.TabIndex = 0;
            this.PortChB.SelectedValueChanged += new System.EventHandler(this.PortChB_SelectedValueChanged);
            this.PortChB.Click += new System.EventHandler(this.PortChB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // wyslijB
            // 
            this.wyslijB.Location = new System.Drawing.Point(105, 145);
            this.wyslijB.Name = "wyslijB";
            this.wyslijB.Size = new System.Drawing.Size(75, 23);
            this.wyslijB.TabIndex = 2;
            this.wyslijB.Text = "Wyslij";
            this.wyslijB.UseVisualStyleBackColor = true;
            this.wyslijB.Click += new System.EventHandler(this.wyslijB_Click);
            // 
            // Wyslij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}