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
            SuspendLayout();
            // 
            // clientesButton
            // 
            clientesButton.Enabled = false;
            clientesButton.Location = new Point(83, 33);
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
            solicitudesButton.Location = new Point(372, 33);
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
            tipoSolicitudesButton.Location = new Point(372, 122);
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
            tecnicosButton.Location = new Point(83, 122);
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
            visitasButton.Location = new Point(641, 33);
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
            tipoMaterialesButton.Location = new Point(641, 122);
            tipoMaterialesButton.Margin = new Padding(2, 1, 2, 1);
            tipoMaterialesButton.Name = "tipoMaterialesButton";
            tipoMaterialesButton.Size = new Size(135, 43);
            tipoMaterialesButton.TabIndex = 8;
            tipoMaterialesButton.Text = "Tipo Materiales";
            tipoMaterialesButton.UseVisualStyleBackColor = true;
            tipoMaterialesButton.Click += materialesButton_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(868, 233);
            Controls.Add(tipoMaterialesButton);
            Controls.Add(visitasButton);
            Controls.Add(tecnicosButton);
            Controls.Add(tipoSolicitudesButton);
            Controls.Add(solicitudesButton);
            Controls.Add(clientesButton);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button clientesButton;
        private Button solicitudesButton;
        private Button tipoSolicitudesButton;
        private Button tecnicosButton;
        private Button visitasButton;
        private Button tipoMaterialesButton;
    }
}