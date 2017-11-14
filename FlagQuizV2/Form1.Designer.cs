namespace FlagQuizV2
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.mainTrainBtn = new System.Windows.Forms.Button();
            this.mainTestBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pickContinentBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(51, 9);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(646, 38);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "WELCOME TO NATIONALISM TRAINING.";
            // 
            // mainTrainBtn
            // 
            this.mainTrainBtn.Location = new System.Drawing.Point(58, 116);
            this.mainTrainBtn.Name = "mainTrainBtn";
            this.mainTrainBtn.Size = new System.Drawing.Size(100, 50);
            this.mainTrainBtn.TabIndex = 1;
            this.mainTrainBtn.Text = "Train me";
            this.mainTrainBtn.UseVisualStyleBackColor = true;
            this.mainTrainBtn.Click += new System.EventHandler(this.mainTrainBtn_Click);
            // 
            // mainTestBtn
            // 
            this.mainTestBtn.Location = new System.Drawing.Point(58, 188);
            this.mainTestBtn.Name = "mainTestBtn";
            this.mainTestBtn.Size = new System.Drawing.Size(100, 50);
            this.mainTestBtn.TabIndex = 2;
            this.mainTestBtn.Text = "Test me";
            this.mainTestBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pickContinentBox
            // 
            this.pickContinentBox.FormattingEnabled = true;
            this.pickContinentBox.Items.AddRange(new object[] {
            "Asia",
            "Africa",
            "Australia",
            "North-America",
            "South-America"});
            this.pickContinentBox.Location = new System.Drawing.Point(201, 116);
            this.pickContinentBox.Name = "pickContinentBox";
            this.pickContinentBox.Size = new System.Drawing.Size(234, 199);
            this.pickContinentBox.TabIndex = 4;
            this.pickContinentBox.SelectedIndexChanged += new System.EventHandler(this.pickContinentBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 466);
            this.Controls.Add(this.pickContinentBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mainTestBtn);
            this.Controls.Add(this.mainTrainBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button mainTrainBtn;
        private System.Windows.Forms.Button mainTestBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox pickContinentBox;
    }
}

