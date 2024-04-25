namespace ClassesImport;

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
        btnAleatorio = new Button();
        btnMessageBox = new Button();
        lblResultado = new Label();
        SuspendLayout();
        // 
        // btnAleatorio
        // 
        btnAleatorio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnAleatorio.Location = new Point(250, 370);
        btnAleatorio.Name = "btnAleatorio";
        btnAleatorio.Size = new Size(235, 59);
        btnAleatorio.TabIndex = 1;
        btnAleatorio.Text = "Aleatorio";
        btnAleatorio.UseVisualStyleBackColor = true;
        btnAleatorio.Click += btnAleatorio_Click;
        // 
        // btnMessageBox
        // 
        btnMessageBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnMessageBox.Location = new Point(12, 370);
        btnMessageBox.Name = "btnMessageBox";
        btnMessageBox.Size = new Size(235, 59);
        btnMessageBox.TabIndex = 1;
        btnMessageBox.Text = "MessageBox";
        btnMessageBox.UseVisualStyleBackColor = true;
        btnMessageBox.Click += btnMessageBox_Click;
        // 
        // lblResultado
        // 
        lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        lblResultado.Location = new Point(11, 9);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new Size(777, 164);
        lblResultado.TabIndex = 0;
        lblResultado.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 438);
        Controls.Add(btnAleatorio);
        Controls.Add(btnMessageBox);
        Controls.Add(lblResultado);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Label lblResultado;
    private Button btnMessageBox;
    private Button btnAleatorio;
}
