namespace graus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbC = new System.Windows.Forms.Label();
            this.btCalcularC = new System.Windows.Forms.Button();
            this.txtF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbF = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btCalcularF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbC);
            this.groupBox1.Controls.Add(this.btCalcularC);
            this.groupBox1.Controls.Add(this.txtF);
            this.groupBox1.Location = new System.Drawing.Point(28, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Fahrenheit pra Celsius";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(71, 66);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(40, 13);
            this.lbC.TabIndex = 3;
            this.lbC.Text = "Celsius";
            this.lbC.Visible = false;
            // 
            // btCalcularC
            // 
            this.btCalcularC.Location = new System.Drawing.Point(149, 28);
            this.btCalcularC.Name = "btCalcularC";
            this.btCalcularC.Size = new System.Drawing.Size(28, 26);
            this.btCalcularC.TabIndex = 2;
            this.btCalcularC.Text = "C°";
            this.btCalcularC.UseVisualStyleBackColor = true;
            this.btCalcularC.Click += new System.EventHandler(this.btCalcularC_Click);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(33, 28);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 20);
            this.txtF.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbF);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.btCalcularF);
            this.groupBox2.Location = new System.Drawing.Point(248, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celsius pra Fahrenheit";
            // 
            // lbF
            // 
            this.lbF.AutoSize = true;
            this.lbF.Location = new System.Drawing.Point(66, 71);
            this.lbF.Name = "lbF";
            this.lbF.Size = new System.Drawing.Size(57, 13);
            this.lbF.TabIndex = 4;
            this.lbF.Text = "Fahrenheit";
            this.lbF.Visible = false;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(30, 32);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 4;
            // 
            // btCalcularF
            // 
            this.btCalcularF.Location = new System.Drawing.Point(152, 32);
            this.btCalcularF.Name = "btCalcularF";
            this.btCalcularF.Size = new System.Drawing.Size(28, 26);
            this.btCalcularF.TabIndex = 4;
            this.btCalcularF.Text = "F°";
            this.btCalcularF.UseVisualStyleBackColor = true;
            this.btCalcularF.Click += new System.EventHandler(this.btCalcularF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 173);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Button btCalcularC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbF;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btCalcularF;
    }
}

