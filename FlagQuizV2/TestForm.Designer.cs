namespace FlagQuizV2
{
    partial class TestForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icelandBtn = new System.Windows.Forms.RadioButton();
            this.swedenBtn = new System.Windows.Forms.RadioButton();
            this.norwayBtn = new System.Windows.Forms.RadioButton();
            this.denmarkBtn = new System.Windows.Forms.RadioButton();
            this.finlandBtn = new System.Windows.Forms.RadioButton();
            this.optionBox = new System.Windows.Forms.GroupBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.optionBox.SuspendLayout();
            this.testBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 219);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // icelandBtn
            // 
            this.icelandBtn.AutoSize = true;
            this.icelandBtn.Location = new System.Drawing.Point(6, 31);
            this.icelandBtn.Name = "icelandBtn";
            this.icelandBtn.Size = new System.Drawing.Size(60, 17);
            this.icelandBtn.TabIndex = 1;
            this.icelandBtn.TabStop = true;
            this.icelandBtn.Text = "Iceland";
            this.icelandBtn.UseVisualStyleBackColor = true;
            // 
            // swedenBtn
            // 
            this.swedenBtn.AutoSize = true;
            this.swedenBtn.Location = new System.Drawing.Point(6, 54);
            this.swedenBtn.Name = "swedenBtn";
            this.swedenBtn.Size = new System.Drawing.Size(64, 17);
            this.swedenBtn.TabIndex = 2;
            this.swedenBtn.TabStop = true;
            this.swedenBtn.Text = "Sweden";
            this.swedenBtn.UseVisualStyleBackColor = true;
            // 
            // norwayBtn
            // 
            this.norwayBtn.AutoSize = true;
            this.norwayBtn.Location = new System.Drawing.Point(6, 77);
            this.norwayBtn.Name = "norwayBtn";
            this.norwayBtn.Size = new System.Drawing.Size(61, 17);
            this.norwayBtn.TabIndex = 3;
            this.norwayBtn.TabStop = true;
            this.norwayBtn.Text = "Norway";
            this.norwayBtn.UseVisualStyleBackColor = true;
            // 
            // denmarkBtn
            // 
            this.denmarkBtn.AutoSize = true;
            this.denmarkBtn.Location = new System.Drawing.Point(6, 100);
            this.denmarkBtn.Name = "denmarkBtn";
            this.denmarkBtn.Size = new System.Drawing.Size(68, 17);
            this.denmarkBtn.TabIndex = 4;
            this.denmarkBtn.TabStop = true;
            this.denmarkBtn.Text = "Denmark";
            this.denmarkBtn.UseVisualStyleBackColor = true;
            this.denmarkBtn.CheckedChanged += new System.EventHandler(this.denmarkBtn_CheckedChanged);
            // 
            // finlandBtn
            // 
            this.finlandBtn.AutoSize = true;
            this.finlandBtn.Location = new System.Drawing.Point(6, 123);
            this.finlandBtn.Name = "finlandBtn";
            this.finlandBtn.Size = new System.Drawing.Size(59, 17);
            this.finlandBtn.TabIndex = 5;
            this.finlandBtn.TabStop = true;
            this.finlandBtn.Text = "Finland";
            this.finlandBtn.UseVisualStyleBackColor = true;
            // 
            // optionBox
            // 
            this.optionBox.Controls.Add(this.swedenBtn);
            this.optionBox.Controls.Add(this.finlandBtn);
            this.optionBox.Controls.Add(this.icelandBtn);
            this.optionBox.Controls.Add(this.denmarkBtn);
            this.optionBox.Controls.Add(this.norwayBtn);
            this.optionBox.Location = new System.Drawing.Point(245, 30);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(131, 219);
            this.optionBox.TabIndex = 6;
            this.optionBox.TabStop = false;
            this.optionBox.Text = "Options";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(403, 30);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(247, 84);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // testBox
            // 
            this.testBox.Controls.Add(this.pictureBox1);
            this.testBox.Controls.Add(this.submitBtn);
            this.testBox.Controls.Add(this.optionBox);
            this.testBox.Location = new System.Drawing.Point(12, 12);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(701, 441);
            this.testBox.TabIndex = 8;
            this.testBox.TabStop = false;
            this.testBox.Text = "groupBox1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 503);
            this.Controls.Add(this.testBox);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.optionBox.ResumeLayout(false);
            this.optionBox.PerformLayout();
            this.testBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton icelandBtn;
        private System.Windows.Forms.RadioButton swedenBtn;
        private System.Windows.Forms.RadioButton norwayBtn;
        private System.Windows.Forms.RadioButton denmarkBtn;
        private System.Windows.Forms.RadioButton finlandBtn;
        private System.Windows.Forms.GroupBox optionBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox testBox;
    }
}