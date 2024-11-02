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
            aceptarButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(83, 33);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(135, 43);
            aceptarButton.TabIndex = 3;
            aceptarButton.Text = "Clientes";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += clientesButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(372, 33);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(135, 43);
            button1.TabIndex = 4;
            button1.Text = "Solicitudes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += solicitudesButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(372, 122);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(135, 43);
            button2.TabIndex = 5;
            button2.Text = "Tipo Solicitudes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += tipoSolicitudesButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(83, 122);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(135, 43);
            button3.TabIndex = 6;
            button3.Text = "Tecnicos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += tecnicosButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(641, 33);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(135, 43);
            button4.TabIndex = 7;
            button4.Text = "Visitas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += visitasButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(641, 122);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(135, 43);
            button5.TabIndex = 8;
            button5.Text = "Tipo Materiales";
            button5.UseVisualStyleBackColor = true;
            button5.Click += materialesButton_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(878, 233);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(aceptarButton);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button aceptarButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}