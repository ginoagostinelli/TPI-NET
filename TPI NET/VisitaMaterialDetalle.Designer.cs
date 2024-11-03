namespace WindowsForms
{
    partial class VisitaMaterialDetalle
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
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            label1 = new Label();
            tipoLabel = new Label();
            label2 = new Label();
            tipoComboBox = new ComboBox();
            cantidadUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadUpDown).BeginInit();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(93, 232);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(92, 27);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(202, 232);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(92, 27);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 26);
            label1.TabIndex = 12;
            label1.Text = "Agregar Material";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            tipoLabel.Location = new Point(23, 68);
            tipoLabel.Margin = new Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(112, 17);
            tipoLabel.TabIndex = 14;
            tipoLabel.Text = "Tipo de Material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            label2.Location = new Point(23, 138);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 16;
            label2.Text = "Cantidad";
            // 
            // tipoComboBox
            // 
            tipoComboBox.FormattingEnabled = true;
            tipoComboBox.Location = new Point(21, 95);
            tipoComboBox.Name = "tipoComboBox";
            tipoComboBox.Size = new Size(273, 23);
            tipoComboBox.TabIndex = 19;
            // 
            // cantidadUpDown
            // 
            cantidadUpDown.Location = new Point(21, 167);
            cantidadUpDown.Name = "cantidadUpDown";
            cantidadUpDown.Size = new Size(120, 23);
            cantidadUpDown.TabIndex = 20;
            // 
            // VisitaMaterialDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 278);
            Controls.Add(cantidadUpDown);
            Controls.Add(tipoComboBox);
            Controls.Add(label2);
            Controls.Add(tipoLabel);
            Controls.Add(label1);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "VisitaMaterialDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Material";
            Load += VisitaMaterialDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantidadUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label label1;
        private Label label2;
        private Label tipoLabel;
        private ComboBox tipoComboBox;
        private NumericUpDown cantidadUpDown;
    }
}