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
            this.ovsBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.vsbSchlägerRechts = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovsStatus = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunter = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnHoch = new System.Windows.Forms.Button();
            this.picSchlägerRechts = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(40, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.AllowDrop = true;
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlägerRechts);
            this.pnlSpiel.Controls.Add(this.shapeContainer1);
            this.pnlSpiel.Location = new System.Drawing.Point(40, 40);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(600, 300);
            this.pnlSpiel.TabIndex = 2;
            // 
            // ovsBall
            // 
            this.ovsBall.BackColor = System.Drawing.Color.Yellow;
            this.ovsBall.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovsBall.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ovsBall.Location = new System.Drawing.Point(0, 0);
            this.ovsBall.Name = "ovsBall";
            this.ovsBall.Size = new System.Drawing.Size(25, 25);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 30;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // vsbSchlägerRechts
            // 
            this.vsbSchlägerRechts.Location = new System.Drawing.Point(643, 40);
            this.vsbSchlägerRechts.Name = "vsbSchlägerRechts";
            this.vsbSchlägerRechts.Size = new System.Drawing.Size(17, 300);
            this.vsbSchlägerRechts.TabIndex = 3;
            this.vsbSchlägerRechts.Value = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Location = new System.Drawing.Point(100, 350);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(50, 20);
            this.txtPunkte.TabIndex = 5;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovsStatus});
            this.shapeContainer2.Size = new System.Drawing.Size(984, 761);
            this.shapeContainer2.TabIndex = 6;
            this.shapeContainer2.TabStop = false;
            // 
            // ovsStatus
            // 
            this.ovsStatus.BackColor = System.Drawing.Color.Red;
            this.ovsStatus.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovsStatus.FillColor = System.Drawing.Color.Red;
            this.ovsStatus.Location = new System.Drawing.Point(150, 350);
            this.ovsStatus.Name = "ovsStatus";
            this.ovsStatus.Size = new System.Drawing.Size(10, 10);
            this.ovsStatus.Click += new System.EventHandler(this.ovsStatus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 100);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tastatursteuerung\r\nTaste\r\nH    horizontale Flugrichtung umkehren\r\nV    vertikale " +
    "Flugrichtung umkehren\r\nP    Spiel pausieren\r\nS    Spiel weiterlaufen lassen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRunter
            // 
            this.btnRunter.BackColor = System.Drawing.Color.White;
            this.btnRunter.Image = global::PingPong.Properties.Resources.glyphicons_arrows_194_white_feathered_downwards_arrow_2x;
            this.btnRunter.Location = new System.Drawing.Point(740, 240);
            this.btnRunter.Name = "btnRunter";
            this.btnRunter.Size = new System.Drawing.Size(40, 40);
            this.btnRunter.TabIndex = 11;
            this.btnRunter.UseVisualStyleBackColor = false;
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.White;
            this.btnRechts.Image = global::PingPong.Properties.Resources.glyphicons_arrows_193_white_feathered_rightwards_arrow_2x;
            this.btnRechts.Location = new System.Drawing.Point(780, 200);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(40, 40);
            this.btnRechts.TabIndex = 10;
            this.btnRechts.UseVisualStyleBackColor = false;
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.White;
            this.btnLinks.Image = global::PingPong.Properties.Resources.glyphicons_arrows_191_white_feathered_leftwards_arrow_2x;
            this.btnLinks.Location = new System.Drawing.Point(700, 200);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(40, 40);
            this.btnLinks.TabIndex = 9;
            this.btnLinks.UseVisualStyleBackColor = false;
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Image = global::PingPong.Properties.Resources.glyphicons_arrows_192_white_feathered_upwards_arrow_2x;
            this.btnHoch.Location = new System.Drawing.Point(740, 160);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(40, 40);
            this.btnHoch.TabIndex = 7;
            this.btnHoch.UseVisualStyleBackColor = false;
            // 
            // picSchlägerRechts
            // 
            this.picSchlägerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlägerRechts.Location = new System.Drawing.Point(590, 149);
            this.picSchlägerRechts.Name = "picSchlägerRechts";
            this.picSchlägerRechts.Size = new System.Drawing.Size(4, 40);
            this.picSchlägerRechts.TabIndex = 4;
            this.picSchlägerRechts.TabStop = false;
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
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRunter);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vsbSchlägerRechts);
            this.Controls.Add(this.pnlSpiel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.shapeContainer2);
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.frmPingPong_Load);
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovsStatus;
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnRunter;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovsBall;
    }
}

