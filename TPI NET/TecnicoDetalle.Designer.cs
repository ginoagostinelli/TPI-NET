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
            label1 = new Label();
            apellidoTextBox = new TextBox();
            label2 = new Label();
            telefonoTextBox = new TextBox();
            label3 = new Label();
            rolComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(131, 21);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(24, 21);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(54, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(239, 172);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(81, 22);
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
            cancelarButton.Location = new Point(331, 172);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(131, 59);
            apellidoTextBox.Margin = new Padding(2, 1, 2, 1);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(110, 23);
            apellidoTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 94);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(131, 94);
            telefonoTextBox.Margin = new Padding(2, 1, 2, 1);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(110, 23);
            telefonoTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 132);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 9;
            label3.Text = "Rol:";
            // 
            // rolComboBox
            // 
            rolComboBox.FormattingEnabled = true;
            rolComboBox.Location = new Point(131, 132);
            rolComboBox.Name = "rolComboBox";
            rolComboBox.Size = new Size(110, 23);
            rolComboBox.TabIndex = 10;
            // 
            // TecnicoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(rolComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(telefonoTextBox);
            Controls.Add(label1);
            Controls.Add(apellidoTextBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(nombreTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "TecnicoDetalle";
            Text = "Cliente";
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
        private Label label3;
        private Label label2;
        private TextBox telefonoTextBox;
        private Label label1;
        private TextBox apellidoTextBox;
        private ComboBox rolComboBox;
    }
}