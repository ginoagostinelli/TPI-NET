namespace TPI_NET
{
    partial class MenuPrincipal
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
            clientesButton = new Button();
            solicitudesButton = new Button();
            tipoSolicitudesButton = new Button();
            tecnicosButton = new Button();
            visitasButton = new Button();
            tipoMaterialesButton = new Button();
            label1 = new Label();
            rolLabel = new Label();
            SuspendLayout();
            // 
            // clientesButton
            // 
            clientesButton.Enabled = false;
            clientesButton.Location = new Point(109, 131);
            clientesButton.Margin = new Padding(2, 1, 2, 1);
            clientesButton.Name = "clientesButton";
            clientesButton.Size = new Size(135, 43);
            clientesButton.TabIndex = 3;
            clientesButton.Text = "Clientes";
            clientesButton.UseVisualStyleBackColor = true;
            clientesButton.Click += clientesButton_Click;
            // 
            // solicitudesButton
            // 
            solicitudesButton.Enabled = false;
            solicitudesButton.Location = new Point(398, 131);
            solicitudesButton.Margin = new Padding(2, 1, 2, 1);
            solicitudesButton.Name = "solicitudesButton";
            solicitudesButton.Size = new Size(135, 43);
            solicitudesButton.TabIndex = 4;
            solicitudesButton.Text = "Solicitudes";
            solicitudesButton.UseVisualStyleBackColor = true;
            solicitudesButton.Click += solicitudesButton_Click;
            // 
            // tipoSolicitudesButton
            // 
            tipoSolicitudesButton.Enabled = false;
            tipoSolicitudesButton.Location = new Point(398, 220);
            tipoSolicitudesButton.Margin = new Padding(2, 1, 2, 1);
            tipoSolicitudesButton.Name = "tipoSolicitudesButton";
            tipoSolicitudesButton.Size = new Size(135, 43);
            tipoSolicitudesButton.TabIndex = 5;
            tipoSolicitudesButton.Text = "Tipo Solicitudes";
            tipoSolicitudesButton.UseVisualStyleBackColor = true;
            tipoSolicitudesButton.Click += tipoSolicitudesButton_Click;
            // 
            // tecnicosButton
            // 
            tecnicosButton.Enabled = false;
            tecnicosButton.Location = new Point(109, 220);
            tecnicosButton.Margin = new Padding(2, 1, 2, 1);
            tecnicosButton.Name = "tecnicosButton";
            tecnicosButton.Size = new Size(135, 43);
            tecnicosButton.TabIndex = 6;
            tecnicosButton.Text = "Tecnicos";
            tecnicosButton.UseVisualStyleBackColor = true;
            tecnicosButton.Click += tecnicosButton_Click;
            // 
            // visitasButton
            // 
            visitasButton.Enabled = false;
            visitasButton.Location = new Point(667, 131);
            visitasButton.Margin = new Padding(2, 1, 2, 1);
            visitasButton.Name = "visitasButton";
            visitasButton.Size = new Size(135, 43);
            visitasButton.TabIndex = 7;
            visitasButton.Text = "Visitas";
            visitasButton.UseVisualStyleBackColor = true;
            visitasButton.Click += visitasButton_Click;
            // 
            // tipoMaterialesButton
            // 
            tipoMaterialesButton.Enabled = false;
            tipoMaterialesButton.Location = new Point(667, 220);
            tipoMaterialesButton.Margin = new Padding(2, 1, 2, 1);
            tipoMaterialesButton.Name = "tipoMaterialesButton";
            tipoMaterialesButton.Size = new Size(135, 43);
            tipoMaterialesButton.TabIndex = 8;
            tipoMaterialesButton.Text = "Tipo Materiales";
            tipoMaterialesButton.UseVisualStyleBackColor = true;
            tipoMaterialesButton.Click += materialesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 26);
            label1.TabIndex = 15;
            label1.Text = "Menu Principal";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rolLabel.Location = new Point(11, 316);
            rolLabel.Margin = new Padding(2, 0, 2, 0);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new Size(39, 22);
            rolLabel.TabIndex = 16;
            rolLabel.Text = "Rol";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(939, 356);
            Controls.Add(rolLabel);
            Controls.Add(label1);
            Controls.Add(tipoMaterialesButton);
            Controls.Add(visitasButton);
            Controls.Add(tecnicosButton);
            Controls.Add(tipoSolicitudesButton);
            Controls.Add(solicitudesButton);
            Controls.Add(clientesButton);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clientesButton;
        private Button solicitudesButton;
        private Button tipoSolicitudesButton;
        private Button tecnicosButton;
        private Button visitasButton;
        private Button tipoMaterialesButton;
        private Label label1;
        private Label rolLabel;
    }
}