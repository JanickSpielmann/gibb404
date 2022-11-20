namespace PingPong
{
    partial class frmPingPong
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vsbSchlägerRechts = new System.Windows.Forms.VScrollBar();
            this.picSchlägerRechts = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 415);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlägerRechts);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(40, 40);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(600, 300);
            this.pnlSpiel.TabIndex = 2;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(489, 183);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(25, 25);
            this.picBall.TabIndex = 3;
            this.picBall.TabStop = false;
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 60;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // vsbSchlägerRechts
            // 
            this.vsbSchlägerRechts.Location = new System.Drawing.Point(643, 40);
            this.vsbSchlägerRechts.Name = "vsbSchlägerRechts";
            this.vsbSchlägerRechts.Size = new System.Drawing.Size(17, 300);
            this.vsbSchlägerRechts.TabIndex = 3;
            this.vsbSchlägerRechts.Value = 50;
            this.vsbSchlägerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlägerRechts_Scroll);
            // 
            // picSchlägerRechts
            // 
            this.picSchlägerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlägerRechts.Location = new System.Drawing.Point(591, 141);
            this.picSchlägerRechts.Name = "picSchlägerRechts";
            this.picSchlägerRechts.Size = new System.Drawing.Size(4, 40);
            this.picSchlägerRechts.TabIndex = 4;
            this.picSchlägerRechts.TabStop = false;
            this.picSchlägerRechts.Click += new System.EventHandler(this.picSchlägerRechts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Location = new System.Drawing.Point(90, 375);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(100, 20);
            this.txtPunkte.TabIndex = 5;
            this.txtPunkte.TextChanged += new System.EventHandler(this.txtPunkte_TextChanged);
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vsbSchlägerRechts);
            this.Controls.Add(this.pnlSpiel);
            this.Controls.Add(this.btnStart);
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox picSchlägerRechts;
        private System.Windows.Forms.VScrollBar vsbSchlägerRechts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPunkte;
    }
}

