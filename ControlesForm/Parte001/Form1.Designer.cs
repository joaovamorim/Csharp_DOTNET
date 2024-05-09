namespace Parte001
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
            labelNomeVariavel = new Label();
            SuspendLayout();
            // 
            // labelNomeVariavel
            // 
            labelNomeVariavel.AutoEllipsis = true;
            labelNomeVariavel.BackColor = SystemColors.AppWorkspace;
            labelNomeVariavel.Font = new Font("Segoe MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeVariavel.ForeColor = SystemColors.MenuHighlight;
            labelNomeVariavel.Location = new Point(12, 9);
            labelNomeVariavel.Name = "labelNomeVariavel";
            labelNomeVariavel.Size = new Size(307, 76);
            labelNomeVariavel.TabIndex = 0;
            labelNomeVariavel.Text = "João";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNomeVariavel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label labelNomeVariavel;
    }
}
