namespace SendingEmail
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToTxtBox = new System.Windows.Forms.TextBox();
            this.SubTxtBox = new System.Windows.Forms.TextBox();
            this.BodyTxtBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblBody = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToTxtBox
            // 
            this.ToTxtBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ToTxtBox.Location = new System.Drawing.Point(200, 80);
            this.ToTxtBox.Name = "ToTxtBox";
            this.ToTxtBox.Size = new System.Drawing.Size(235, 23);
            this.ToTxtBox.TabIndex = 0;
            this.ToTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SubTxtBox
            // 
            this.SubTxtBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SubTxtBox.Location = new System.Drawing.Point(200, 123);
            this.SubTxtBox.Name = "SubTxtBox";
            this.SubTxtBox.Size = new System.Drawing.Size(235, 23);
            this.SubTxtBox.TabIndex = 2;
            // 
            // BodyTxtBox
            // 
            this.BodyTxtBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BodyTxtBox.Location = new System.Drawing.Point(200, 173);
            this.BodyTxtBox.Multiline = true;
            this.BodyTxtBox.Name = "BodyTxtBox";
            this.BodyTxtBox.Size = new System.Drawing.Size(235, 85);
            this.BodyTxtBox.TabIndex = 3;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(123, 80);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(26, 20);
            this.Label.TabIndex = 4;
            this.Label.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblBody
            // 
            this.LblBody.AutoSize = true;
            this.LblBody.BackColor = System.Drawing.Color.Transparent;
            this.LblBody.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBody.Location = new System.Drawing.Point(123, 172);
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(45, 20);
            this.LblBody.TabIndex = 6;
            this.LblBody.Text = "Body";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(200, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(365, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 15);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Attachment";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.BodyTxtBox);
            this.Controls.Add(this.SubTxtBox);
            this.Controls.Add(this.ToTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ToTxtBox;
        private TextBox SubTxtBox;
        private TextBox BodyTxtBox;
        private Label Label;
        private Label label2;
        private Label LblBody;
        private Button button1;
        private LinkLabel linkLabel1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label3;
    }
}