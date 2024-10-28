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
            tecnicosDataGridView = new DataGridView();
            agregarButton = new Button();
            eliminarButton = new Button();
            modificarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tecnicosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tecnicosDataGridView
            // 
            tecnicosDataGridView.AllowUserToOrderColumns = true;
            tecnicosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tecnicosDataGridView.Location = new Point(21, 18);
            tecnicosDataGridView.Margin = new Padding(2, 1, 2, 1);
            tecnicosDataGridView.MultiSelect = false;
            tecnicosDataGridView.Name = "tecnicosDataGridView";
            tecnicosDataGridView.ReadOnly = true;
            tecnicosDataGridView.RowHeadersWidth = 82;
            tecnicosDataGridView.RowTemplate.Height = 41;
            tecnicosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tecnicosDataGridView.Size = new Size(689, 270);
            tecnicosDataGridView.TabIndex = 0;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(629, 304);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(444, 304);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 2;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(536, 304);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(81, 22);
            modificarButton.TabIndex = 3;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // TecnicoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 351);
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
        }

        #endregion

        private DataGridView tecnicosDataGridView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button modificarButton;
    }
}