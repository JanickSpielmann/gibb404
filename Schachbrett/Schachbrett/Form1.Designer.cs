namespace Schachbrett
{
    partial class frmSchachbrett
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSchachbrett = new System.Windows.Forms.FlowLayoutPanel();
            this.nudAnzahlZeilen = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlZeilen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.nudAnzahlZeilen);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 76);
            this.panel1.TabIndex = 0;
            // 
            // pnlSchachbrett
            // 
            this.pnlSchachbrett.BackColor = System.Drawing.Color.White;
            this.pnlSchachbrett.Location = new System.Drawing.Point(12, 93);
            this.pnlSchachbrett.Name = "pnlSchachbrett";
            this.pnlSchachbrett.Size = new System.Drawing.Size(776, 345);
            this.pnlSchachbrett.TabIndex = 1;
            // 
            // nudAnzahlZeilen
            // 
            this.nudAnzahlZeilen.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAnzahlZeilen.Location = new System.Drawing.Point(3, 25);
            this.nudAnzahlZeilen.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAnzahlZeilen.Name = "nudAnzahlZeilen";
            this.nudAnzahlZeilen.Size = new System.Drawing.Size(69, 26);
            this.nudAnzahlZeilen.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(78, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // frmSchachbrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSchachbrett);
            this.Controls.Add(this.panel1);
            this.Name = "frmSchachbrett";
            this.Text = "Schachbrett";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlZeilen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudAnzahlZeilen;
        private System.Windows.Forms.FlowLayoutPanel pnlSchachbrett;
    }
}

