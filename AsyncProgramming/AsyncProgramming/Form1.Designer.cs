namespace AsyncProgramming
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.lblResult3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process File 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(321, 162);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Process File 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Process File 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.lblResult1.AccessibleName = "lblResult1";
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(160, 161);
            this.lblResult1.Name = "label1";
            this.lblResult1.Size = new System.Drawing.Size(0, 13);
            this.lblResult1.TabIndex = 5;
            // 
            // label2
            // 
            this.lblResult2.AccessibleName = "lblResult2";
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(346, 162);
            this.lblResult2.Name = "label2";
            this.lblResult2.Size = new System.Drawing.Size(0, 13);
            this.lblResult2.TabIndex = 6;
            // 
            // label3
            // 
            this.lblResult3.AccessibleName = "lblResult3";
            this.lblResult3.AutoSize = true;
            this.lblResult3.Location = new System.Drawing.Point(503, 162);
            this.lblResult3.Name = "label3";
            this.lblResult3.Size = new System.Drawing.Size(0, 13);
            this.lblResult3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult3);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label lblResult3;
    }
}

