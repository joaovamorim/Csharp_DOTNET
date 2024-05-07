namespace Formulario
{
    partial class FormSegunda
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
            label1 = new Label();
            btnFormPrincipal = new Button();
            txtMensagem = new TextBox();
            btnRetorno = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 99);
            label1.Name = "label1";
            label1.Size = new Size(355, 65);
            label1.TabIndex = 0;
            label1.Text = "Segunda Form";
            // 
            // btnFormPrincipal
            // 
            btnFormPrincipal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormPrincipal.Location = new Point(12, 370);
            btnFormPrincipal.Name = "btnFormPrincipal";
            btnFormPrincipal.Size = new Size(212, 68);
            btnFormPrincipal.TabIndex = 1;
            btnFormPrincipal.Text = "Form Principal";
            btnFormPrincipal.UseVisualStyleBackColor = true;
            btnFormPrincipal.Click += btnFormPrincipal_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMensagem.Location = new Point(157, 204);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(486, 43);
            txtMensagem.TabIndex = 2;
            // 
            // btnRetorno
            // 
            btnRetorno.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetorno.Location = new Point(249, 370);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Size = new Size(212, 68);
            btnRetorno.TabIndex = 3;
            btnRetorno.Text = "Retorno";
            btnRetorno.UseVisualStyleBackColor = true;
            btnRetorno.Click += btnRetorno_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.Location = new Point(486, 370);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(212, 68);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormSegunda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnRetorno);
            Controls.Add(txtMensagem);
            Controls.Add(btnFormPrincipal);
            Controls.Add(label1);
            Name = "FormSegunda";
            Text = "FormSegunda";
            Load += FormSegunda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFormPrincipal;
        private TextBox txtMensagem;
        private Button btnRetorno;
        private Button btnFechar;
    }
}