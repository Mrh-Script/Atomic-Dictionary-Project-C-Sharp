namespace AtomicDictionary
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            panel2 = new Panel();
            exitLabel = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Crimson;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 0);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(exitLabel);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 125);
            panel2.TabIndex = 1;
            // 
            // exitLabel
            // 
            exitLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exitLabel.ForeColor = Color.WhiteSmoke;
            exitLabel.Location = new Point(1035, 15);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(30, 29);
            exitLabel.TabIndex = 3;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 50F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(91, 19);
            label1.Name = "label1";
            label1.Size = new Size(891, 95);
            label1.TabIndex = 2;
            label1.Text = "ATOM INFORMATION";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 181);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 15);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Crimson;
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 529);
            panel4.Name = "panel4";
            panel4.Size = new Size(1072, 43);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(602, 4);
            label2.Name = "label2";
            label2.Size = new Size(453, 32);
            label2.TabIndex = 4;
            label2.Text = "Reference : Modern Periodic Table";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(256, 143);
            label3.Name = "label3";
            label3.Size = new Size(559, 339);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Cambria", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(958, 174);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(71, 36);
            button1.TabIndex = 5;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(1032, 48);
            label4.Name = "label4";
            label4.Size = new Size(35, 32);
            label4.TabIndex = 4;
            label4.Text = "☐";
            label4.Click += label4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 572);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label exitLabel;
        private Label label4;
    }
}