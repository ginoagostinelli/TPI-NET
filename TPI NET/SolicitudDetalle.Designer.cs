namespace WindowsForms
{
    partial class SolicitudDetalle
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
            esatdoLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            motivoLabel = new Label();
            motivoBox = new TextBox();
            fechaLabel = new Label();
            fechaBox = new TextBox();
            conclusionLabel = new Label();
            conclusionBox = new TextBox();
            tipoLabel = new Label();
            label1 = new Label();
            clienteLabel = new Label();
            clienteBox = new ComboBox();
            tipoBox = new ComboBox();
            estadoBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // esatdoLabel
            // 
            esatdoLabel.AutoSize = true;
            esatdoLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            esatdoLabel.Location = new Point(22, 78);
            esatdoLabel.Margin = new Padding(2, 0, 2, 0);
            esatdoLabel.Name = "esatdoLabel";
            esatdoLabel.Size = new Size(54, 17);
            esatdoLabel.TabIndex = 1;
            esatdoLabel.Text = "Estado";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(391, 462);
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
            cancelarButton.Location = new Point(500, 462);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(92, 27);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // motivoLabel
            // 
            motivoLabel.AutoSize = true;
            motivoLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            motivoLabel.Location = new Point(22, 225);
            motivoLabel.Margin = new Padding(2, 0, 2, 0);
            motivoLabel.Name = "motivoLabel";
            motivoLabel.Size = new Size(52, 17);
            motivoLabel.TabIndex = 5;
            motivoLabel.Text = "Motivo";
            // 
            // motivoBox
            // 
            motivoBox.BackColor = SystemColors.Window;
            motivoBox.BorderStyle = BorderStyle.FixedSingle;
            motivoBox.Location = new Point(22, 252);
            motivoBox.Margin = new Padding(2, 1, 2, 1);
            motivoBox.Multiline = true;
            motivoBox.Name = "motivoBox";
            motivoBox.Size = new Size(590, 60);
            motivoBox.TabIndex = 4;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            fechaLabel.Location = new Point(343, 78);
            fechaLabel.Margin = new Padding(2, 0, 2, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(49, 17);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha";
            // 
            // fechaBox
            // 
            fechaBox.BackColor = SystemColors.Window;
            fechaBox.BorderStyle = BorderStyle.FixedSingle;
            fechaBox.Enabled = false;
            fechaBox.Location = new Point(341, 105);
            fechaBox.Margin = new Padding(2, 1, 2, 1);
            fechaBox.Name = "fechaBox";
            fechaBox.Size = new Size(273, 23);
            fechaBox.TabIndex = 6;
            // 
            // conclusionLabel
            // 
            conclusionLabel.AutoSize = true;
            conclusionLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            conclusionLabel.Location = new Point(22, 336);
            conclusionLabel.Margin = new Padding(2, 0, 2, 0);
            conclusionLabel.Name = "conclusionLabel";
            conclusionLabel.Size = new Size(81, 17);
            conclusionLabel.TabIndex = 9;
            conclusionLabel.Text = "Conclusion";
            // 
            // conclusionBox
            // 
            conclusionBox.BackColor = SystemColors.Window;
            conclusionBox.BorderStyle = BorderStyle.FixedSingle;
            conclusionBox.Location = new Point(22, 367);
            conclusionBox.Margin = new Padding(2, 1, 2, 1);
            conclusionBox.Multiline = true;
            conclusionBox.Name = "conclusionBox";
            conclusionBox.Size = new Size(590, 60);
            conclusionBox.TabIndex = 8;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            tipoLabel.Location = new Point(22, 148);
            tipoLabel.Margin = new Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(36, 17);
            tipoLabel.TabIndex = 11;
            tipoLabel.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 26);
            label1.TabIndex = 12;
            label1.Text = "Datos Solicitud";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            clienteLabel.Location = new Point(343, 148);
            clienteLabel.Margin = new Padding(2, 0, 2, 0);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new Size(53, 17);
            clienteLabel.TabIndex = 13;
            clienteLabel.Text = "Cliente";
            // 
            // clienteBox
            // 
            clienteBox.FormattingEnabled = true;
            clienteBox.Location = new Point(341, 177);
            clienteBox.Name = "clienteBox";
            clienteBox.Size = new Size(273, 23);
            clienteBox.TabIndex = 20;
            // 
            // tipoBox
            // 
            tipoBox.FormattingEnabled = true;
            tipoBox.Location = new Point(22, 177);
            tipoBox.Name = "tipoBox";
            tipoBox.Size = new Size(273, 23);
            tipoBox.TabIndex = 21;
            // 
            // estadoBox
            // 
            estadoBox.FormattingEnabled = true;
            estadoBox.Items.AddRange(new object[] { "En curso", "Completado", "Cancelada" });
            estadoBox.Location = new Point(22, 105);
            estadoBox.Name = "estadoBox";
            estadoBox.Size = new Size(273, 23);
            estadoBox.TabIndex = 22;
            // 
            // SolicitudDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(636, 508);
            Controls.Add(estadoBox);
            Controls.Add(tipoBox);
            Controls.Add(clienteBox);
            Controls.Add(clienteLabel);
            Controls.Add(label1);
            Controls.Add(tipoLabel);
            Controls.Add(conclusionLabel);
            Controls.Add(conclusionBox);
            Controls.Add(fechaLabel);
            Controls.Add(fechaBox);
            Controls.Add(motivoLabel);
            Controls.Add(motivoBox);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(esatdoLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "SolicitudDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solicitud";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label esatdoLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label motivoLabel;
        private TextBox motivoBox;
        private Label tipoLabel;
        private Label conclusionLabel;
        private TextBox conclusionBox;
        private Label fechaLabel;
        private TextBox fechaBox;
        private Label label1;
        private Label clienteLabel;
        private ComboBox estadoBox;
        private ComboBox tipoBox;
        private ComboBox clienteBox;
    }
}