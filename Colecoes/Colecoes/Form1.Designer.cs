namespace Colecoes
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
            lista = new ListBox();
            btnList = new Button();
            SuspendLayout();
            // 
            // lista
            // 
            lista.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lista.FormattingEnabled = true;
            lista.ItemHeight = 37;
            lista.Location = new Point(12, 12);
            lista.Name = "lista";
            lista.Size = new Size(535, 411);
            lista.TabIndex = 0;
            // 
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnList.Location = new Point(553, 12);
            btnList.Name = "btnList";
            btnList.Size = new Size(235, 59);
            btnList.TabIndex = 1;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnList);
            Controls.Add(lista);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listas Genericas";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lista;
        private Button btnList;
    }
}
