namespace Exc1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            distanceRTb = new RichTextBox();
            calBtn = new Button();
            label4 = new Label();
            billLabel = new Label();
            priceDispl = new Label();
            feeLabel = new Label();
            distanceLabel = new Label();
            distanceDispl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(18, 9);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 45);
            label1.TabIndex = 0;
            label1.Text = "Tính tiền grab";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bill;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(18, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(686, 221);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 299);
            label2.Name = "label2";
            label2.Size = new Size(153, 45);
            label2.TabIndex = 2;
            label2.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 321);
            label3.Name = "label3";
            label3.Size = new Size(0, 45);
            label3.TabIndex = 3;
            // 
            // distanceRTb
            // 
            distanceRTb.Location = new Point(28, 347);
            distanceRTb.Multiline = false;
            distanceRTb.Name = "distanceRTb";
            distanceRTb.Size = new Size(353, 61);
            distanceRTb.TabIndex = 4;
            distanceRTb.Text = "";
            distanceRTb.KeyDown += distanceRTb_KeyDown;
            // 
            // calBtn
            // 
            calBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            calBtn.Location = new Point(517, 344);
            calBtn.Name = "calBtn";
            calBtn.Size = new Size(175, 61);
            calBtn.TabIndex = 5;
            calBtn.Text = "Calculate!";
            calBtn.UseVisualStyleBackColor = true;
            calBtn.Click += calBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 353);
            label4.Name = "label4";
            label4.Size = new Size(71, 45);
            label4.TabIndex = 6;
            label4.Text = "Km";
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Location = new Point(338, 444);
            billLabel.Name = "billLabel";
            billLabel.Size = new Size(68, 45);
            billLabel.TabIndex = 7;
            billLabel.Text = "Bill";
            billLabel.Visible = false;
            // 
            // priceDispl
            // 
            priceDispl.AutoSize = true;
            priceDispl.ForeColor = Color.Firebrick;
            priceDispl.Location = new Point(200, 577);
            priceDispl.Name = "priceDispl";
            priceDispl.Size = new Size(96, 45);
            priceDispl.TabIndex = 8;
            priceDispl.Text = "Price";
            priceDispl.Visible = false;
            // 
            // feeLabel
            // 
            feeLabel.AutoSize = true;
            feeLabel.Location = new Point(28, 577);
            feeLabel.Name = "feeLabel";
            feeLabel.Size = new Size(166, 45);
            feeLabel.TabIndex = 9;
            feeLabel.Text = "Your fee: ";
            feeLabel.Visible = false;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new Point(28, 513);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(162, 45);
            distanceLabel.TabIndex = 10;
            distanceLabel.Text = "Distance:";
            distanceLabel.Visible = false;
            // 
            // distanceDispl
            // 
            distanceDispl.AutoSize = true;
            distanceDispl.ForeColor = Color.Firebrick;
            distanceDispl.Location = new Point(200, 513);
            distanceDispl.Name = "distanceDispl";
            distanceDispl.Size = new Size(153, 45);
            distanceDispl.TabIndex = 11;
            distanceDispl.Text = "Distance";
            distanceDispl.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 695);
            //set start position
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(distanceDispl);
            Controls.Add(distanceLabel);
            Controls.Add(feeLabel);
            Controls.Add(priceDispl);
            Controls.Add(billLabel);
            Controls.Add(label4);
            Controls.Add(calBtn);
            Controls.Add(distanceRTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(9);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Exercise 1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private RichTextBox distanceRTb;
        private Button calBtn;
        private Label label4;
        public Label billLabel;
        public Label priceDispl;
        public Label feeLabel;
        public Label distanceLabel;
        public Label distanceDispl;
    }
}