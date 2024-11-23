namespace TPI_NET
{
    partial class ClienteLista
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgvLista = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            busquedaTextBox = new TextBox();
            label2 = new Label();
            limpiarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvLista.DefaultCellStyle = dataGridViewCellStyle8;
            dgvLista.GridColor = SystemColors.InactiveCaption;
            dgvLista.Location = new Point(12, 90);
            dgvLista.Name = "dgvLista";
            dataGridViewCellStyle9.BackColor = Color.DarkGray;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dgvLista.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvLista.Size = new Size(923, 294);
            dgvLista.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Times New Roman", 11.25F);
            btnAgregar.Location = new Point(281, 405);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Times New Roman", 11.25F);
            btnModificar.Location = new Point(427, 405);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 33);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += modificarButton_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Times New Roman", 11.25F);
            btnEliminar.Location = new Point(575, 405);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 33);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += eliminarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 26);
            label1.TabIndex = 13;
            label1.Text = "Lista Clientes";
            // 
            // busquedaTextBox
            // 
            busquedaTextBox.Location = new Point(103, 61);
            busquedaTextBox.Name = "busquedaTextBox";
            busquedaTextBox.Size = new Size(270, 23);
            busquedaTextBox.TabIndex = 14;
            busquedaTextBox.TextChanged += busquedaTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 64);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 15;
            label2.Text = "Búsqueda:";
            // 
            // limpiarButton
            // 
            limpiarButton.Location = new Point(379, 61);
            limpiarButton.Name = "limpiarButton";
            limpiarButton.Size = new Size(121, 23);
            limpiarButton.TabIndex = 16;
            limpiarButton.Text = "Limpiar búsqueda";
            limpiarButton.UseVisualStyleBackColor = true;
            limpiarButton.Click += limpiarButton_Click;
            // 
            // ClienteLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(947, 450);
            Controls.Add(limpiarButton);
            Controls.Add(label2);
            Controls.Add(busquedaTextBox);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvLista);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ClienteLista";
            Text = "Lista Clientes";
            Load += ClienteLista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLista;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private TextBox busquedaTextBox;
        private Label label2;
        private Button limpiarButton;
    }
}
