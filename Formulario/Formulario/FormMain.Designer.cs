namespace Formulario
{
    partial class FormMain
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
            lblTitulo = new Label();
            btnSegunda = new Button();
            btnSegundaFormThread = new Button();
            menuBar = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            mFileNovo = new ToolStripMenuItem();
            mFileAbrir = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mFileSair = new ToolStripMenuItem();
            menuHelp = new ToolStripMenuItem();
            mHelpSobre = new ToolStripMenuItem();
            mHelpSobreDev = new ToolStripMenuItem();
            mHelpSobreVer = new ToolStripMenuItem();
            comboMenu = new ToolStripComboBox();
            mPesquisar = new ToolStripTextBox();
            menuBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 75);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(776, 150);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Principal";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSegunda
            // 
            btnSegunda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSegunda.Location = new Point(12, 370);
            btnSegunda.Name = "btnSegunda";
            btnSegunda.Size = new Size(217, 68);
            btnSegunda.TabIndex = 1;
            btnSegunda.Text = "Segunda Form";
            btnSegunda.UseVisualStyleBackColor = true;
            btnSegunda.Click += btnSegunda_Click;
            // 
            // btnSegundaFormThread
            // 
            btnSegundaFormThread.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSegundaFormThread.Location = new Point(255, 370);
            btnSegundaFormThread.Name = "btnSegundaFormThread";
            btnSegundaFormThread.Size = new Size(217, 68);
            btnSegundaFormThread.TabIndex = 2;
            btnSegundaFormThread.Text = "Segunda Form Thread";
            btnSegundaFormThread.UseVisualStyleBackColor = true;
            btnSegundaFormThread.Click += btnSegundaFormThread_Click;
            // 
            // menuBar
            // 
            menuBar.Items.AddRange(new ToolStripItem[] { menuFile, menuHelp, comboMenu, mPesquisar });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(800, 27);
            menuBar.TabIndex = 3;
            menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { mFileNovo, mFileAbrir, toolStripSeparator1, mFileSair });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 23);
            menuFile.Text = "File";
            // 
            // mFileNovo
            // 
            mFileNovo.Name = "mFileNovo";
            mFileNovo.ShortcutKeyDisplayString = "";
            mFileNovo.ShortcutKeys = Keys.Control | Keys.X;
            mFileNovo.Size = new Size(180, 22);
            mFileNovo.Text = "Novo";
            mFileNovo.Click += mFileNovo_Click;
            // 
            // mFileAbrir
            // 
            mFileAbrir.Name = "mFileAbrir";
            mFileAbrir.ShortcutKeys = Keys.Control | Keys.Alt | Keys.F;
            mFileAbrir.Size = new Size(180, 22);
            mFileAbrir.Text = "Abrir";
            mFileAbrir.Click += mFileAbrir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mFileSair
            // 
            mFileSair.Name = "mFileSair";
            mFileSair.ShortcutKeys = Keys.Control | Keys.I;
            mFileSair.Size = new Size(180, 22);
            mFileSair.Text = "Sair";
            mFileSair.Click += mFileSair_Click;
            // 
            // menuHelp
            // 
            menuHelp.DropDownItems.AddRange(new ToolStripItem[] { mHelpSobre });
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new Size(44, 23);
            menuHelp.Text = "Help";
            // 
            // mHelpSobre
            // 
            mHelpSobre.DropDownItems.AddRange(new ToolStripItem[] { mHelpSobreDev, mHelpSobreVer });
            mHelpSobre.Name = "mHelpSobre";
            mHelpSobre.Size = new Size(180, 22);
            mHelpSobre.Text = "Sobre";
            // 
            // mHelpSobreDev
            // 
            mHelpSobreDev.Name = "mHelpSobreDev";
            mHelpSobreDev.Size = new Size(152, 22);
            mHelpSobreDev.Text = "Desenvolvedor";
            mHelpSobreDev.Click += mHelpSobreDev_Click;
            // 
            // mHelpSobreVer
            // 
            mHelpSobreVer.Name = "mHelpSobreVer";
            mHelpSobreVer.Size = new Size(152, 22);
            mHelpSobreVer.Text = "Versão";
            mHelpSobreVer.Click += mHelpSobreVer_Click;
            // 
            // comboMenu
            // 
            comboMenu.Items.AddRange(new object[] { "Inglês", "Português" });
            comboMenu.Name = "comboMenu";
            comboMenu.Size = new Size(121, 23);
            comboMenu.SelectedIndexChanged += comboMenu_SelectedIndexChanged;
            // 
            // mPesquisar
            // 
            mPesquisar.Name = "mPesquisar";
            mPesquisar.Size = new Size(200, 23);
            mPesquisar.KeyUp += mPesquisar_KeyUp;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSegundaFormThread);
            Controls.Add(btnSegunda);
            Controls.Add(lblTitulo);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Principal";
            Load += FormMain_Load;
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnSegunda;
        private Button btnSegundaFormThread;
        private MenuStrip menuBar;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem mFileNovo;
        private ToolStripMenuItem mFileAbrir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mFileSair;
        private ToolStripMenuItem menuHelp;
        private ToolStripMenuItem mHelpSobre;
        private ToolStripMenuItem mHelpSobreDev;
        private ToolStripMenuItem mHelpSobreVer;
        private ToolStripComboBox comboMenu;
        private ToolStripTextBox mPesquisar;
    }
}
