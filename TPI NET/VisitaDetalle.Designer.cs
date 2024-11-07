namespace WindowsForms
{
    partial class VisitaDetalle
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
            descripcionTextBox = new TextBox();
            nombreLabel = new Label();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            direccionLabel = new Label();
            label1 = new Label();
            volverCheckBox = new CheckBox();
            tecnicoComboBox = new ComboBox();
            materialesGridView = new DataGridView();
            label2 = new Label();
            agregarMaterialButton = new Button();
            eliminarMaterialButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialesGridView).BeginInit();
            SuspendLayout();
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.BackColor = SystemColors.Window;
            descripcionTextBox.BorderStyle = BorderStyle.FixedSingle;
            descripcionTextBox.Location = new Point(22, 94);
            descripcionTextBox.Margin = new Padding(2, 1, 2, 1);
            descripcionTextBox.Multiline = true;
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(273, 80);
            descripcionTextBox.TabIndex = 0;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            nombreLabel.Location = new Point(22, 66);
            nombreLabel.Margin = new Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(86, 17);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Descripción";
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(614, 325);
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
            cancelarButton.Location = new Point(723, 325);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(92, 27);
            cancelarButton.TabIndex = 3;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            direccionLabel.Location = new Point(22, 236);
            direccionLabel.Margin = new Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(60, 17);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "Técnico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 12;
            label1.Text = "Datos Visita";
            // 
            // volverCheckBox
            // 
            volverCheckBox.AutoSize = true;
            volverCheckBox.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            volverCheckBox.Location = new Point(22, 187);
            volverCheckBox.Name = "volverCheckBox";
            volverCheckBox.Size = new Size(128, 21);
            volverCheckBox.TabIndex = 13;
            volverCheckBox.Text = "Se debe volver.";
            volverCheckBox.UseVisualStyleBackColor = true;
            // 
            // tecnicoComboBox
            // 
            tecnicoComboBox.FormattingEnabled = true;
            tecnicoComboBox.Location = new Point(20, 266);
            tecnicoComboBox.Name = "tecnicoComboBox";
            tecnicoComboBox.Size = new Size(273, 23);
            tecnicoComboBox.TabIndex = 14;
            // 
            // materialesGridView
            // 
            materialesGridView.BackgroundColor = SystemColors.ButtonFace;
            materialesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materialesGridView.Location = new Point(338, 95);
            materialesGridView.Name = "materialesGridView";
            materialesGridView.Size = new Size(446, 194);
            materialesGridView.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Italic);
            label2.Location = new Point(338, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 17);
            label2.TabIndex = 16;
            label2.Text = "Materiales utillizados";
            // 
            // agregarMaterialButton
            // 
            agregarMaterialButton.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarMaterialButton.Location = new Point(790, 94);
            agregarMaterialButton.Name = "agregarMaterialButton";
            agregarMaterialButton.Size = new Size(25, 45);
            agregarMaterialButton.TabIndex = 17;
            agregarMaterialButton.Text = "+";
            agregarMaterialButton.UseVisualStyleBackColor = true;
            agregarMaterialButton.Click += agregarMaterialbutton_Click;
            // 
            // eliminarMaterialButton
            // 
            eliminarMaterialButton.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarMaterialButton.Location = new Point(790, 145);
            eliminarMaterialButton.Name = "eliminarMaterialButton";
            eliminarMaterialButton.Size = new Size(25, 45);
            eliminarMaterialButton.TabIndex = 18;
            eliminarMaterialButton.Text = "-";
            eliminarMaterialButton.UseVisualStyleBackColor = true;
            // 
            // VisitaDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(842, 368);
            Controls.Add(eliminarMaterialButton);
            Controls.Add(agregarMaterialButton);
            Controls.Add(label2);
            Controls.Add(materialesGridView);
            Controls.Add(tecnicoComboBox);
            Controls.Add(volverCheckBox);
            Controls.Add(label1);
            Controls.Add(direccionLabel);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreLabel);
            Controls.Add(descripcionTextBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "VisitaDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visita";
            Load += VisitaDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionTextBox;
        private Label nombreLabel;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label direccionLabel;
        private Label label1;
        private CheckBox volverCheckBox;
        private ComboBox tecnicoComboBox;
        private Button eliminarMaterialButton;
        private Button agregarMaterialButton;
        private Label label2;
        private DataGridView materialesGridView;
    }
}