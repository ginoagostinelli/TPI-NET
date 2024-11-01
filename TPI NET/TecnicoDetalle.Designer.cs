namespace WindowsForms
{
    partial class TecnicoDetalle
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
            components = new System.ComponentModel.Container();
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            apellidoLabel = new Label();
            apellidoTextBox = new TextBox();
            telefonoLabel = new Label();
            telefonoTextBox = new TextBox();
            label1 = new Label();
            razonLabel = new Label();
            label2 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            contraTextBox = new TextBox();
            rolComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.BackColor = SystemColors.Window;
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Location = new Point(22, 94);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(273, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            nombreLabel.Location = new Point(22, 66);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(61, 17);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(96, 492);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(92, 27);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(205, 492);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(92, 27);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            apellidoLabel.Location = new Point(24, 131);
            apellidoLabel.Margin = new Padding(2, 0, 2, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(59, 17);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "Apellido";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.BackColor = SystemColors.Window;
            apellidoTextBox.BorderStyle = BorderStyle.FixedSingle;
            apellidoTextBox.Location = new Point(24, 159);
            apellidoTextBox.Margin = new Padding(2, 1, 2, 1);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(273, 23);
            apellidoTextBox.TabIndex = 4;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            telefonoLabel.Location = new Point(24, 201);
            telefonoLabel.Margin = new Padding(2, 0, 2, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(63, 17);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.BackColor = SystemColors.Window;
            telefonoTextBox.BorderStyle = BorderStyle.FixedSingle;
            telefonoTextBox.Location = new Point(24, 228);
            telefonoTextBox.Margin = new Padding(2, 1, 2, 1);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(273, 23);
            telefonoTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 26);
            label1.TabIndex = 12;
            label1.Text = "Datos Tecnico";
            // 
            // razonLabel
            // 
            razonLabel.AutoSize = true;
            razonLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            razonLabel.Location = new Point(26, 271);
            razonLabel.Margin = new Padding(2, 0, 2, 0);
            razonLabel.Name = "razonLabel";
            razonLabel.Size = new Size(30, 17);
            razonLabel.TabIndex = 14;
            razonLabel.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            label2.Location = new Point(26, 341);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 16;
            label2.Text = "e-Mail";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.Window;
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(24, 368);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(273, 23);
            emailTextBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            label3.Location = new Point(26, 412);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 18;
            label3.Text = "Contraseña";
            // 
            // contraTextBox
            // 
            contraTextBox.BackColor = SystemColors.Window;
            contraTextBox.BorderStyle = BorderStyle.FixedSingle;
            contraTextBox.Location = new Point(24, 439);
            contraTextBox.Margin = new Padding(2, 1, 2, 1);
            contraTextBox.Name = "contraTextBox";
            contraTextBox.Size = new Size(273, 23);
            contraTextBox.TabIndex = 17;
            // 
            // rolComboBox
            // 
            rolComboBox.FormattingEnabled = true;
            rolComboBox.Location = new Point(24, 298);
            rolComboBox.Name = "rolComboBox";
            rolComboBox.Size = new Size(273, 23);
            rolComboBox.TabIndex = 19;
            // 
            // TecnicoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 527);
            Controls.Add(rolComboBox);
            Controls.Add(label3);
            Controls.Add(contraTextBox);
            Controls.Add(label2);
            Controls.Add(emailTextBox);
            Controls.Add(razonLabel);
            Controls.Add(label1);
            Controls.Add(telefonoLabel);
            Controls.Add(telefonoTextBox);
            Controls.Add(apellidoLabel);
            Controls.Add(apellidoTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "TecnicoDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tecnico";
            Load += TecnicoDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label apellidoLabel;
        private TextBox apellidoTextBox;
        private Label telefonoLabel;
        private TextBox telefonoTextBox;
        private Label label1;
        private Label label2;
        private TextBox emailTextBox;
        private Label razonLabel;
        private Label label3;
        private TextBox contraTextBox;
        private ComboBox rolComboBox;
    }
}