namespace AtomicDictionary
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
            panel1 = new Panel();
            label4 = new Label();
            exitLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label2 = new Label();
            searchButton = new Button();
            panel4 = new Panel();
            label3 = new Label();
            inputBox = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(exitLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 115);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(1030, 44);
            label4.Name = "label4";
            label4.Size = new Size(35, 32);
            label4.TabIndex = 2;
            label4.Text = "☐";
            label4.Click += label4_Click;
            // 
            // exitLabel
            // 
            exitLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitLabel.ForeColor = Color.WhiteSmoke;
            exitLabel.Location = new Point(1030, 12);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(30, 29);
            exitLabel.TabIndex = 1;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 55F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(23, 3);
            label1.Name = "label1";
            label1.Size = new Size(992, 104);
            label1.TabIndex = 0;
            label1.Text = "ATOMIC DICTIONARY";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.CadetBlue;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 13);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 524);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 48);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Selena", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(770, 12);
            label5.Name = "label5";
            label5.Size = new Size(293, 29);
            label5.TabIndex = 6;
            label5.Text = "PoweredBy \"Riad's Tutorial\"";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(698, -77);
            label2.Name = "label2";
            label2.Size = new Size(367, 32);
            label2.TabIndex = 3;
            label2.Text = "PoweredBy \"Riad's Tutorial\"";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.None;
            searchButton.BackColor = Color.Crimson;
            searchButton.BackgroundImageLayout = ImageLayout.Center;
            searchButton.CausesValidation = false;
            searchButton.Cursor = Cursors.Hand;
            searchButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchButton.ForeColor = Color.LavenderBlush;
            searchButton.Location = new Point(459, 413);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(143, 45);
            searchButton.TabIndex = 3;
            searchButton.Text = "FIND ATOM";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(255, 255, 128);
            panel4.Controls.Add(label3);
            panel4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel4.Location = new Point(0, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(1072, 79);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(113, 0);
            label3.Name = "label3";
            label3.Size = new Size(863, 69);
            label3.TabIndex = 1;
            label3.Text = "Enter Atom's Name or Symbol :";
            label3.Click += label3_Click;
            // 
            // inputBox
            // 
            inputBox.Anchor = AnchorStyles.None;
            inputBox.Cursor = Cursors.IBeam;
            inputBox.Font = new Font("Cambria", 60F);
            inputBox.ForeColor = Color.Crimson;
            inputBox.Location = new Point(283, 251);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(517, 125);
            inputBox.TabIndex = 5;
            inputBox.TextChanged += inputBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 572);
            Controls.Add(inputBox);
            Controls.Add(panel4);
            Controls.Add(searchButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button searchButton;
        private Panel panel4;
        private Label label3;
        private TextBox inputBox;
        private Label exitLabel;
        private Label label4;
        private Label label5;
    }
}
