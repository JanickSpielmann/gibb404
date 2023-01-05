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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpSteuerung = new System.Windows.Forms.GroupBox();
            this.rdbSchläger = new System.Windows.Forms.RadioButton();
            this.rdbBall = new System.Windows.Forms.RadioButton();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpSteuerung.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(60, 585);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 62);
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
            this.pnlSpiel.Location = new System.Drawing.Point(60, 62);
            this.pnlSpiel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(899, 460);
            this.pnlSpiel.TabIndex = 2;
            // 
            // picSchlägerRechts
            // 
            this.picSchlägerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlägerRechts.Location = new System.Drawing.Point(885, 229);
            this.picSchlägerRechts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSchlägerRechts.Name = "picSchlägerRechts";
            this.picSchlägerRechts.Size = new System.Drawing.Size(6, 62);
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
            this.shapeContainer1.Size = new System.Drawing.Size(897, 458);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // ovsBall
            // 
            this.ovsBall.BackColor = System.Drawing.Color.Yellow;
            this.ovsBall.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovsBall.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ovsBall.Location = new System.Drawing.Point(553, 158);
            this.ovsBall.Name = "ovsBall";
            this.ovsBall.Size = new System.Drawing.Size(25, 26);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 30;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // vsbSchlägerRechts
            // 
            this.vsbSchlägerRechts.Location = new System.Drawing.Point(964, 62);
            this.vsbSchlägerRechts.Name = "vsbSchlägerRechts";
            this.vsbSchlägerRechts.Size = new System.Drawing.Size(17, 462);
            this.vsbSchlägerRechts.TabIndex = 3;
            this.vsbSchlägerRechts.Value = 50;
            this.vsbSchlägerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlägerRechts_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 538);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Location = new System.Drawing.Point(135, 538);
            this.txtPunkte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(73, 26);
            this.txtPunkte.TabIndex = 5;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovsStatus});
            this.shapeContainer2.Size = new System.Drawing.Size(1476, 1171);
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
            this.button2.Location = new System.Drawing.Point(64, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(12, 12);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 585);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 154);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tastatursteuerung\r\nTaste\r\nH    horizontale Flugrichtung umkehren\r\nV    vertikale " +
    "Flugrichtung umkehren\r\nP    Spiel pausieren\r\nS    Spiel weiterlaufen lassen\r\n";
            // 
            // btnRunter
            // 
            this.btnRunter.BackColor = System.Drawing.Color.White;
            this.btnRunter.Image = global::PingPong.Properties.Resources.glyphicons_arrows_194_white_feathered_downwards_arrow_2x;
            this.btnRunter.Location = new System.Drawing.Point(1110, 369);
            this.btnRunter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRunter.Name = "btnRunter";
            this.btnRunter.Size = new System.Drawing.Size(60, 62);
            this.btnRunter.TabIndex = 11;
            this.btnRunter.UseVisualStyleBackColor = false;
            this.btnRunter.Click += new System.EventHandler(this.btnRunter_Click);
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.White;
            this.btnRechts.Image = global::PingPong.Properties.Resources.glyphicons_arrows_193_white_feathered_rightwards_arrow_2x;
            this.btnRechts.Location = new System.Drawing.Point(1170, 308);
            this.btnRechts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(60, 62);
            this.btnRechts.TabIndex = 10;
            this.btnRechts.UseVisualStyleBackColor = false;
            this.btnRechts.Click += new System.EventHandler(this.btnRechts_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.White;
            this.btnLinks.Image = global::PingPong.Properties.Resources.glyphicons_arrows_191_white_feathered_leftwards_arrow_2x;
            this.btnLinks.Location = new System.Drawing.Point(1050, 308);
            this.btnLinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(60, 62);
            this.btnLinks.TabIndex = 9;
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Image = global::PingPong.Properties.Resources.glyphicons_arrows_192_white_feathered_upwards_arrow_2x;
            this.btnHoch.Location = new System.Drawing.Point(1110, 246);
            this.btnHoch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(60, 62);
            this.btnHoch.TabIndex = 7;
            this.btnHoch.UseVisualStyleBackColor = false;
            this.btnHoch.Click += new System.EventHandler(this.btnHoch_Click);
            // 
            // grpSteuerung
            // 
            this.grpSteuerung.Controls.Add(this.rdbSchläger);
            this.grpSteuerung.Controls.Add(this.rdbBall);
            this.grpSteuerung.Location = new System.Drawing.Point(964, 585);
            this.grpSteuerung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSteuerung.Name = "grpSteuerung";
            this.grpSteuerung.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSteuerung.Size = new System.Drawing.Size(206, 154);
            this.grpSteuerung.TabIndex = 13;
            this.grpSteuerung.TabStop = false;
            this.grpSteuerung.Text = "Wahl der Steuerung";
            // 
            // rdbSchläger
            // 
            this.rdbSchläger.AutoSize = true;
            this.rdbSchläger.Location = new System.Drawing.Point(9, 68);
            this.rdbSchläger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbSchläger.Name = "rdbSchläger";
            this.rdbSchläger.Size = new System.Drawing.Size(169, 24);
            this.rdbSchläger.TabIndex = 1;
            this.rdbSchläger.TabStop = true;
            this.rdbSchläger.Text = "Schlägersteuerung";
            this.rdbSchläger.UseVisualStyleBackColor = true;
            // 
            // rdbBall
            // 
            this.rdbBall.AutoSize = true;
            this.rdbBall.Location = new System.Drawing.Point(9, 32);
            this.rdbBall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbBall.Name = "rdbBall";
            this.rdbBall.Size = new System.Drawing.Size(132, 24);
            this.rdbBall.TabIndex = 0;
            this.rdbBall.TabStop = true;
            this.rdbBall.Text = "Ballsteuerung";
            this.rdbBall.UseVisualStyleBackColor = true;
            this.rdbBall.CheckedChanged += new System.EventHandler(this.rdbBall_CheckedChanged);
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1171);
            this.Controls.Add(this.grpSteuerung);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.Load += new System.EventHandler(this.frmPingPong_Load);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSchlägerRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpSteuerung.ResumeLayout(false);
            this.grpSteuerung.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpSteuerung;
        private System.Windows.Forms.RadioButton rdbSchläger;
        private System.Windows.Forms.RadioButton rdbBall;
    }
}

