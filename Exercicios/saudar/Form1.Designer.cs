namespace saudar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rcMsg = new System.Windows.Forms.RichTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcGirl = new System.Windows.Forms.PictureBox();
            this.pcBoy = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcGirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoy)).BeginInit();
            this.SuspendLayout();
            // 
            // rcMsg
            // 
            this.rcMsg.Location = new System.Drawing.Point(151, 188);
            this.rcMsg.Name = "rcMsg";
            this.rcMsg.ReadOnly = true;
            this.rcMsg.Size = new System.Drawing.Size(180, 99);
            this.rcMsg.TabIndex = 0;
            this.rcMsg.Text = "";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(105, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(93, 56);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 2;
            this.cbSexo.Tag = "";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(139, 102);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe seu sexo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btOk);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 137);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // pcGirl
            // 
            this.pcGirl.Image = ((System.Drawing.Image)(resources.GetObject("pcGirl.Image")));
            this.pcGirl.Location = new System.Drawing.Point(273, 233);
            this.pcGirl.Name = "pcGirl";
            this.pcGirl.Size = new System.Drawing.Size(58, 54);
            this.pcGirl.TabIndex = 6;
            this.pcGirl.TabStop = false;
            this.pcGirl.Visible = false;
            // 
            // pcBoy
            // 
            this.pcBoy.Image = ((System.Drawing.Image)(resources.GetObject("pcBoy.Image")));
            this.pcBoy.Location = new System.Drawing.Point(267, 233);
            this.pcBoy.Name = "pcBoy";
            this.pcBoy.Size = new System.Drawing.Size(64, 49);
            this.pcBoy.TabIndex = 7;
            this.pcBoy.TabStop = false;
            this.pcBoy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 316);
            this.Controls.Add(this.pcBoy);
            this.Controls.Add(this.pcGirl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rcMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcGirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rcMsg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcGirl;
        private System.Windows.Forms.PictureBox pcBoy;
    }
}

