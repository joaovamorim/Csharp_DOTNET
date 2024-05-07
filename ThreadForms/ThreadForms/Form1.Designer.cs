namespace ThreadForms
{
    partial class Form1
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
            lblResultado = new Label();
            btnPrincipal = new Button();
            btnContador = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(25, 25);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(738, 320);
            lblResultado.TabIndex = 0;
            // 
            // btnPrincipal
            // 
            btnPrincipal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrincipal.Location = new Point(25, 366);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(245, 72);
            btnPrincipal.TabIndex = 1;
            btnPrincipal.Text = "Principal";
            btnPrincipal.UseVisualStyleBackColor = true;
            btnPrincipal.Click += btnPrincipal_Click;
            // 
            // btnContador
            // 
            btnContador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnContador.Location = new Point(518, 366);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(245, 72);
            btnContador.TabIndex = 2;
            btnContador.Text = "Contador";
            btnContador.UseVisualStyleBackColor = true;
            btnContador.Click += btnContador_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContador);
            Controls.Add(btnPrincipal);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblResultado;
        private Button btnPrincipal;
        private Button btnContador;
    }
}
