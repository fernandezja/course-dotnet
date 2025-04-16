namespace WinFormsApp4
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
            button1 = new Button();
            label1 = new Label();
            btnUsuariosBuscar = new Button();
            txtUsuarioBuscar = new TextBox();
            listUsuarios = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 83);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "Ver la hora";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnUsuariosBuscar
            // 
            btnUsuariosBuscar.Location = new Point(263, 202);
            btnUsuariosBuscar.Margin = new Padding(4, 5, 4, 5);
            btnUsuariosBuscar.Name = "btnUsuariosBuscar";
            btnUsuariosBuscar.Size = new Size(107, 38);
            btnUsuariosBuscar.TabIndex = 2;
            btnUsuariosBuscar.Text = "Buscar";
            btnUsuariosBuscar.UseVisualStyleBackColor = true;
            btnUsuariosBuscar.Click += btnUsuariosBuscar_Click;
            // 
            // txtUsuarioBuscar
            // 
            txtUsuarioBuscar.Location = new Point(17, 202);
            txtUsuarioBuscar.Margin = new Padding(4, 5, 4, 5);
            txtUsuarioBuscar.Name = "txtUsuarioBuscar";
            txtUsuarioBuscar.Size = new Size(235, 31);
            txtUsuarioBuscar.TabIndex = 3;
            // 
            // listUsuarios
            // 
            listUsuarios.FormattingEnabled = true;
            listUsuarios.Location = new Point(17, 267);
            listUsuarios.Margin = new Padding(4, 5, 4, 5);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(351, 379);
            listUsuarios.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 750);
            Controls.Add(listUsuarios);
            Controls.Add(txtUsuarioBuscar);
            Controls.Add(btnUsuariosBuscar);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btnUsuariosBuscar;
        private TextBox txtUsuarioBuscar;
        private ListBox listUsuarios;
    }
}
