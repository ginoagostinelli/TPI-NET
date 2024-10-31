namespace WindowsForms
{
    partial class ClienteDetalle
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
            razonLabel = new Label();
            razonTextBox = new TextBox();
            direccionLabel = new Label();
            direccionTextBox = new TextBox();
            telefonoLabel = new Label();
            telefonoTextBox = new TextBox();
            label1 = new Label();
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
            aceptarButton.Location = new Point(96, 417);
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
            cancelarButton.Location = new Point(205, 417);
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
            // razonLabel
            // 
            razonLabel.AutoSize = true;
            razonLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            razonLabel.Location = new Point(24, 202);
            razonLabel.Margin = new Padding(2, 0, 2, 0);
            razonLabel.Name = "razonLabel";
            razonLabel.Size = new Size(94, 17);
            razonLabel.TabIndex = 7;
            razonLabel.Text = "Razon Social";
            // 
            // razonTextBox
            // 
            razonTextBox.BackColor = SystemColors.Window;
            razonTextBox.BorderStyle = BorderStyle.FixedSingle;
            razonTextBox.Location = new Point(22, 229);
            razonTextBox.Margin = new Padding(2, 1, 2, 1);
            razonTextBox.Name = "razonTextBox";
            razonTextBox.Size = new Size(273, 23);
            razonTextBox.TabIndex = 6;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            direccionLabel.Location = new Point(24, 270);
            direccionLabel.Margin = new Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(70, 17);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "Direccion";
            // 
            // direccionTextBox
            // 
            direccionTextBox.BackColor = SystemColors.Window;
            direccionTextBox.BorderStyle = BorderStyle.FixedSingle;
            direccionTextBox.Location = new Point(22, 299);
            direccionTextBox.Margin = new Padding(2, 1, 2, 1);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(273, 23);
            direccionTextBox.TabIndex = 8;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            telefonoLabel.Location = new Point(24, 343);
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
            telefonoTextBox.Location = new Point(24, 370);
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
            label1.Size = new Size(150, 26);
            label1.TabIndex = 12;
            label1.Text = "Datos Cliente";
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 454);
            Controls.Add(label1);
            Controls.Add(telefonoLabel);
            Controls.Add(telefonoTextBox);
            Controls.Add(direccionLabel);
            Controls.Add(direccionTextBox);
            Controls.Add(razonLabel);
            Controls.Add(razonTextBox);
            Controls.Add(apellidoLabel);
            Controls.Add(apellidoTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ClienteDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
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
        private Label direccionLabel;
        private TextBox direccionTextBox;
        private Label razonLabel;
        private TextBox razonTextBox;
        private Label label1;
    }
}