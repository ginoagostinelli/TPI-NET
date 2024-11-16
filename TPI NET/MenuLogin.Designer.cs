namespace TPI_NET
{
    partial class MenuLogin
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
            ingresarButton = new Button();
            btnSalir = new Button();
            label1 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            contraTextBox = new TextBox();
            invalidosLabel = new Label();
            SuspendLayout();
            // 
            // ingresarButton
            // 
            ingresarButton.Font = new Font("Times New Roman", 11.25F);
            ingresarButton.Location = new Point(12, 191);
            ingresarButton.Name = "ingresarButton";
            ingresarButton.Size = new Size(111, 33);
            ingresarButton.TabIndex = 1;
            ingresarButton.Text = "Ingresar";
            ingresarButton.UseVisualStyleBackColor = true;
            ingresarButton.Click += ingresarButton_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Times New Roman", 11.25F);
            btnSalir.Location = new Point(161, 191);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 33);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 26);
            label1.TabIndex = 13;
            label1.Text = "Login";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(127, 69);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 72);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 15;
            label2.Text = "e-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 115);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 17;
            label3.Text = "Contraseña:";
            // 
            // contraTextBox
            // 
            contraTextBox.Location = new Point(127, 112);
            contraTextBox.Name = "contraTextBox";
            contraTextBox.PasswordChar = '*';
            contraTextBox.Size = new Size(100, 23);
            contraTextBox.TabIndex = 16;
            // 
            // invalidosLabel
            // 
            invalidosLabel.AutoSize = true;
            invalidosLabel.ForeColor = SystemColors.Desktop;
            invalidosLabel.Location = new Point(57, 154);
            invalidosLabel.Name = "invalidosLabel";
            invalidosLabel.Size = new Size(182, 15);
            invalidosLabel.TabIndex = 18;
            invalidosLabel.Text = "Usuario y/o contraseña inválidos!";
            invalidosLabel.Visible = false;
            // 
            // MenuLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(285, 238);
            Controls.Add(invalidosLabel);
            Controls.Add(label3);
            Controls.Add(contraTextBox);
            Controls.Add(label2);
            Controls.Add(emailTextBox);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(ingresarButton);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MenuLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ingresarButton;
        private Button btnSalir;
        private Label label1;
        private TextBox emailTextBox;
        private Label label2;
        private Label label3;
        private TextBox contraTextBox;
        private Label invalidosLabel;
    }
}
