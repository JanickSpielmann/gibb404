namespace Calculator
{
    partial class frmTaschenrechner
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
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnMittelwert = new System.Windows.Forms.Button();
            this.btnPotenz = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddition.Location = new System.Drawing.Point(103, 327);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(126, 34);
            this.btnAddition.TabIndex = 1;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubtraktion.Location = new System.Drawing.Point(240, 327);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(126, 34);
            this.btnSubtraktion.TabIndex = 2;
            this.btnSubtraktion.Text = "Subtraktion";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnMittelwert
            // 
            this.btnMittelwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMittelwert.Location = new System.Drawing.Point(103, 367);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(126, 34);
            this.btnMittelwert.TabIndex = 3;
            this.btnMittelwert.Text = " Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            // 
            // btnPotenz
            // 
            this.btnPotenz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPotenz.Location = new System.Drawing.Point(240, 367);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(126, 34);
            this.btnPotenz.TabIndex = 4;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.btnPotenz_Click);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMaximum.Location = new System.Drawing.Point(103, 407);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(126, 34);
            this.btnMaximum.TabIndex = 5;
            this.btnMaximum.Text = "Maximum";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // txtOperand1
            // 
            this.txtOperand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOperand1.Location = new System.Drawing.Point(103, 143);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(106, 26);
            this.txtOperand1.TabIndex = 6;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOperand2.Location = new System.Drawing.Point(266, 143);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 26);
            this.txtOperand2.TabIndex = 7;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOperator.Location = new System.Drawing.Point(229, 143);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(0, 20);
            this.lblOperator.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(99, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ergebnis:";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.BackColor = System.Drawing.Color.White;
            this.lblErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblErgebnis.Location = new System.Drawing.Point(262, 234);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(104, 20);
            this.lblErgebnis.TabIndex = 10;
            // 
            // frmTaschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 587);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.btnMaximum);
            this.Controls.Add(this.btnPotenz);
            this.Controls.Add(this.btnMittelwert);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btnAddition);
            this.Name = "frmTaschenrechner";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnMittelwert;
        private System.Windows.Forms.Button btnPotenz;
        private System.Windows.Forms.Button btnMaximum;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErgebnis;
    }
}

