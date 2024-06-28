namespace WinFormsApp2
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
            lblMousePosition = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            txtCount = new TextBox();
            btnGenerate = new Button();
            panel2 = new Panel();
            lblTitle2 = new Label();
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMousePosition
            // 
            lblMousePosition.Anchor = AnchorStyles.Bottom;
            lblMousePosition.AutoSize = true;
            lblMousePosition.BackColor = SystemColors.GrayText;
            lblMousePosition.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMousePosition.ForeColor = Color.White;
            lblMousePosition.Location = new Point(329, 416);
            lblMousePosition.Name = "lblMousePosition";
            lblMousePosition.Size = new Size(157, 25);
            lblMousePosition.TabIndex = 4;
            lblMousePosition.Text = "lblMousePosition";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            listBox1.Location = new Point(466, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(254, 94);
            listBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Location = new Point(348, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 110);
            panel1.TabIndex = 6;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(35, 242);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(186, 23);
            txtCount.TabIndex = 7;
            txtCount.Text = "3";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(35, 272);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTitle2);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnSearch);
            panel2.Location = new Point(25, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 168);
            panel2.TabIndex = 9;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle2.Location = new Point(7, 112);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(79, 25);
            lblTitle2.TabIndex = 7;
            lblTitle2.Text = "lblTitle2";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(7, 57);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "label1";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(7, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(186, 23);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(199, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(btnGenerate);
            Controls.Add(txtCount);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(lblMousePosition);
            Name = "Form1";
            Text = "Form1";
            MouseMove += Form1_MouseMove;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMousePosition;
        private ListBox listBox1;
        private Panel panel1;
        private TextBox txtCount;
        private Button btnGenerate;
        private Panel panel2;
        private Label lblTitle2;
        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
