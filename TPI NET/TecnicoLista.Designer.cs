namespace WindowsForms
{
    partial class TecnicoLista
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tecnicosDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tecnicosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tecnicosDataGridView
            // 
            tecnicosDataGridView.AllowUserToOrderColumns = true;
            tecnicosDataGridView.BackgroundColor = SystemColors.ButtonFace;
            tecnicosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tecnicosDataGridView.GridColor = SystemColors.InactiveCaption;
            tecnicosDataGridView.Location = new Point(12, 59);
            tecnicosDataGridView.MultiSelect = false;
            tecnicosDataGridView.Name = "tecnicosDataGridView";
            tecnicosDataGridView.ReadOnly = true;
            tecnicosDataGridView.RowHeadersWidth = 82;
            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tecnicosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            tecnicosDataGridView.RowTemplate.Height = 41;
            tecnicosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tecnicosDataGridView.Size = new Size(923, 325);
            tecnicosDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Font = new Font("Times New Roman", 11.25F);
            agregarButton.Location = new Point(262, 402);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(111, 33);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Font = new Font("Times New Roman", 11.25F);
            eliminarButton.Location = new Point(556, 402);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(111, 33);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Font = new Font("Times New Roman", 11.25F);
            modificarButton.Location = new Point(408, 402);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(111, 33);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 26);
            label1.TabIndex = 14;
            label1.Text = "Lista Tecnicos";
            // 
            // TecnicoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(947, 450);
            Controls.Add(label1);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(tecnicosDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "TecnicoLista";
            Text = "Tecnicos";
            Load += Tecnicos_Load;
            ((System.ComponentModel.ISupportInitialize)tecnicosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tecnicosDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
        private Label label1;
    }
}