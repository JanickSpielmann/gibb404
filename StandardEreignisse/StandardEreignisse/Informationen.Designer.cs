namespace StandardEreignisse
{
    partial class frmInformationen
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
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.btnNewWriter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(552, 666);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(75, 23);
            this.btnSchliessen.TabIndex = 0;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(333, 312);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(158, 13);
            this.lblAusgabe.TabIndex = 1;
            this.lblAusgabe.Text = "Dies ist das Informationsformular";
            // 
            // btnNewWriter
            // 
            this.btnNewWriter.Location = new System.Drawing.Point(336, 417);
            this.btnNewWriter.Name = "btnNewWriter";
            this.btnNewWriter.Size = new System.Drawing.Size(75, 23);
            this.btnNewWriter.TabIndex = 2;
            this.btnNewWriter.Text = "New Writer";
            this.btnNewWriter.UseVisualStyleBackColor = true;
            this.btnNewWriter.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmInformationen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btnNewWriter);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.btnSchliessen);
            this.Name = "frmInformationen";
            this.Text = "Informationen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.Button btnNewWriter;
    }
}