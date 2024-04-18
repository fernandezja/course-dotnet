namespace Starwars.App
{
    partial class FormInit
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
            btnAplicar = new Button();
            txtAncho = new TextBox();
            txtAlto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblMensajeError = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            txtOpacity = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(28, 111);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(75, 23);
            btnAplicar.TabIndex = 0;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(30, 36);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(100, 23);
            txtAncho.TabIndex = 1;
            txtAncho.Text = "400";
            txtAncho.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAlto
            // 
            txtAlto.Location = new Point(145, 36);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(100, 23);
            txtAlto.TabIndex = 2;
            txtAlto.Text = "700";
            txtAlto.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Ancho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 19);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Alto";
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(33, 65);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(89, 15);
            lblMensajeError.TabIndex = 5;
            lblMensajeError.Text = "lblMensajeError";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            comboBox1.Location = new Point(171, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 253);
            panel1.TabIndex = 8;
            // 
            // txtOpacity
            // 
            txtOpacity.Location = new Point(262, 36);
            txtOpacity.Name = "txtOpacity";
            txtOpacity.Size = new Size(100, 23);
            txtOpacity.TabIndex = 9;
            txtOpacity.Text = "100";
            txtOpacity.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 19);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 10;
            label3.Text = "Opacity";
            // 
            // FormInit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 699);
            Controls.Add(label3);
            Controls.Add(txtOpacity);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(lblMensajeError);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAlto);
            Controls.Add(txtAncho);
            Controls.Add(btnAplicar);
            Name = "FormInit";
            Text = "Main/Home";
            Load += FormInit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAplicar;
        private TextBox txtAncho;
        private TextBox txtAlto;
        private Label label1;
        private Label label2;
        private Label lblMensajeError;
        private ComboBox comboBox1;
        private Panel panel1;
        private TextBox txtOpacity;
        private Label label3;
    }
}
