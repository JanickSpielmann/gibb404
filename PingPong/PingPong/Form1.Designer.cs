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
            this.picSchlägerRechts = new System.Windows.Forms.PictureBox();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vsbSchlägerRechts = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovsBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.pnlSpiel.Controls.Add(this.shapeContainer1);
            this.pnlSpiel.Location = new System.Drawing.Point(40, 40);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(600, 300);
            this.pnlSpiel.TabIndex = 2;
            // 
            // picSchlägerRechts
            // 
            this.picSchlägerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlägerRechts.Location = new System.Drawing.Point(590, 141);
            this.picSchlägerRechts.Name = "picSchlägerRechts";
            this.picSchlägerRechts.Size = new System.Drawing.Size(4, 40);
            this.picSchlägerRechts.TabIndex = 4;
            this.picSchlägerRechts.TabStop = false;
            this.picSchlägerRechts.Click += new System.EventHandler(this.picSchlägerRechts_Click);
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovsBall});
            this.shapeContainer1.Size = new System.Drawing.Size(598, 298);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // ovsBall
            // 
            this.ovsBall.BackColor = System.Drawing.Color.Yellow;
            this.ovsBall.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovsBall.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ovsBall.Location = new System.Drawing.Point(149, 98);
            this.ovsBall.Name = "ovsBall";
            this.ovsBall.Size = new System.Drawing.Size(25, 25);
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
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox picSchlägerRechts;
        private System.Windows.Forms.VScrollBar vsbSchlägerRechts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPunkte;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovsBall;
    }
}

