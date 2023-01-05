namespace StandardEreignisse
{
    partial class frmWriter
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
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.btnInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtAusgabe.Enabled = false;
            this.txtAusgabe.Location = new System.Drawing.Point(48, 45);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(860, 1000);
            this.txtAusgabe.TabIndex = 0;
            this.txtAusgabe.TextChanged += new System.EventHandler(this.txtAusgabe_TextChanged);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(833, 1051);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(75, 25);
            this.btnInformation.TabIndex = 1;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // frmWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 1161);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.txtAusgabe);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWriter";
            this.Text = "Writer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.Button btnInformation;
    }
}

