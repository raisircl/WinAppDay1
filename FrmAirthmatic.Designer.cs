namespace WinAppDay1
{
    partial class FrmAirthmatic
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
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(278, 125);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(79, 46);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(192, 187);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 16);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Your Result:";
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.btnSum.ForeColor = System.Drawing.Color.White;
            this.btnSum.Location = new System.Drawing.Point(197, 125);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 46);
            this.btnSum.TabIndex = 14;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(197, 84);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(259, 22);
            this.txtN2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter 2nd Number";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(197, 48);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(259, 22);
            this.txtN1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter 1st Number";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to My Software";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAirthmatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAirthmatic";
            this.Text = "FrmAirthmatic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}