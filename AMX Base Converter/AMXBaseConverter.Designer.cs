namespace AMX_Base_Converter
{
    partial class AMXBaseConverter
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFromBase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbToBase = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumOut = new System.Windows.Forms.TextBox();
            this.linkCopyright = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tbNumIn);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cbFromBase);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cbToBase);
            this.flowLayoutPanel1.Controls.Add(this.btnConvert);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.tbNumOut);
            this.flowLayoutPanel1.Controls.Add(this.linkCopyright);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 229);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number:";
            // 
            // tbNumIn
            // 
            this.tbNumIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumIn.Location = new System.Drawing.Point(120, 3);
            this.tbNumIn.Name = "tbNumIn";
            this.tbNumIn.Size = new System.Drawing.Size(152, 29);
            this.tbNumIn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Base:      ";
            // 
            // cbFromBase
            // 
            this.cbFromBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFromBase.FormattingEnabled = true;
            this.cbFromBase.Location = new System.Drawing.Point(119, 38);
            this.cbFromBase.Name = "cbFromBase";
            this.cbFromBase.Size = new System.Drawing.Size(153, 29);
            this.cbFromBase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "To Base:           ";
            // 
            // cbToBase
            // 
            this.cbToBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToBase.FormattingEnabled = true;
            this.cbToBase.Location = new System.Drawing.Point(117, 65);
            this.cbToBase.Name = "cbToBase";
            this.cbToBase.Size = new System.Drawing.Size(155, 29);
            this.cbToBase.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(3, 92);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(269, 50);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Converted:     ";
            // 
            // tbNumOut
            // 
            this.tbNumOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumOut.Location = new System.Drawing.Point(114, 148);
            this.tbNumOut.Name = "tbNumOut";
            this.tbNumOut.Size = new System.Drawing.Size(158, 29);
            this.tbNumOut.TabIndex = 8;
            // 
            // linkCopyright
            // 
            this.linkCopyright.AutoSize = true;
            this.linkCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCopyright.Location = new System.Drawing.Point(3, 180);
            this.linkCopyright.Name = "linkCopyright";
            this.linkCopyright.Size = new System.Drawing.Size(193, 21);
            this.linkCopyright.TabIndex = 9;
            this.linkCopyright.TabStop = true;
            this.linkCopyright.Text = "© Afaan Bilal, AMX Infinity";
            this.linkCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCopyright_LinkClicked);
            // 
            // AMXBaseConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AMXBaseConverter";
            this.Text = "AMX Base Converter";
            this.Load += new System.EventHandler(this.AMXBaseConverter_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFromBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbToBase;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumOut;
        private System.Windows.Forms.LinkLabel linkCopyright;

    }
}

