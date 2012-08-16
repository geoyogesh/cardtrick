namespace CardTrickWinForm
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
            this.btnpool3 = new System.Windows.Forms.Button();
            this.btnpool2 = new System.Windows.Forms.Button();
            this.lbxpool3 = new System.Windows.Forms.ListBox();
            this.lbxpool2 = new System.Windows.Forms.ListBox();
            this.lbxpool1 = new System.Windows.Forms.ListBox();
            this.btnpool1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpool3
            // 
            this.btnpool3.Location = new System.Drawing.Point(345, 77);
            this.btnpool3.Name = "btnpool3";
            this.btnpool3.Size = new System.Drawing.Size(75, 23);
            this.btnpool3.TabIndex = 11;
            this.btnpool3.Text = "pool3";
            this.btnpool3.UseVisualStyleBackColor = true;
            this.btnpool3.Click += new System.EventHandler(this.btnpool3_Click);
            // 
            // btnpool2
            // 
            this.btnpool2.Location = new System.Drawing.Point(204, 77);
            this.btnpool2.Name = "btnpool2";
            this.btnpool2.Size = new System.Drawing.Size(75, 23);
            this.btnpool2.TabIndex = 10;
            this.btnpool2.Text = "Pool2";
            this.btnpool2.UseVisualStyleBackColor = true;
            this.btnpool2.Click += new System.EventHandler(this.btnpool2_Click);
            // 
            // lbxpool3
            // 
            this.lbxpool3.FormattingEnabled = true;
            this.lbxpool3.Location = new System.Drawing.Point(329, 120);
            this.lbxpool3.Name = "lbxpool3";
            this.lbxpool3.Size = new System.Drawing.Size(120, 95);
            this.lbxpool3.TabIndex = 9;
            // 
            // lbxpool2
            // 
            this.lbxpool2.FormattingEnabled = true;
            this.lbxpool2.Location = new System.Drawing.Point(179, 120);
            this.lbxpool2.Name = "lbxpool2";
            this.lbxpool2.Size = new System.Drawing.Size(120, 95);
            this.lbxpool2.TabIndex = 8;
            // 
            // lbxpool1
            // 
            this.lbxpool1.FormattingEnabled = true;
            this.lbxpool1.Location = new System.Drawing.Point(32, 120);
            this.lbxpool1.Name = "lbxpool1";
            this.lbxpool1.Size = new System.Drawing.Size(120, 95);
            this.lbxpool1.TabIndex = 7;
            // 
            // btnpool1
            // 
            this.btnpool1.Location = new System.Drawing.Point(53, 77);
            this.btnpool1.Name = "btnpool1";
            this.btnpool1.Size = new System.Drawing.Size(75, 23);
            this.btnpool1.TabIndex = 6;
            this.btnpool1.Text = "Pool1";
            this.btnpool1.UseVisualStyleBackColor = true;
            this.btnpool1.Click += new System.EventHandler(this.btnpool1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 372);
            this.Controls.Add(this.btnpool3);
            this.Controls.Add(this.btnpool2);
            this.Controls.Add(this.lbxpool3);
            this.Controls.Add(this.lbxpool2);
            this.Controls.Add(this.lbxpool1);
            this.Controls.Add(this.btnpool1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpool3;
        private System.Windows.Forms.Button btnpool2;
        private System.Windows.Forms.ListBox lbxpool3;
        private System.Windows.Forms.ListBox lbxpool2;
        private System.Windows.Forms.ListBox lbxpool1;
        private System.Windows.Forms.Button btnpool1;
    }
}

