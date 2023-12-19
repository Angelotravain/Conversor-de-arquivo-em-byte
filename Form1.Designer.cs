namespace ConversorByte
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
            txtArquivo = new TextBox();
            btnSelecionarArquivo = new Button();
            btnConverter = new Button();
            txtSaida = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtArquivo
            // 
            txtArquivo.Enabled = false;
            txtArquivo.Location = new Point(84, 22);
            txtArquivo.Name = "txtArquivo";
            txtArquivo.Size = new Size(438, 27);
            txtArquivo.TabIndex = 0;
            // 
            // btnSelecionarArquivo
            // 
            btnSelecionarArquivo.Location = new Point(546, 22);
            btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            btnSelecionarArquivo.Size = new Size(142, 29);
            btnSelecionarArquivo.TabIndex = 2;
            btnSelecionarArquivo.Text = "Selecionar Arquivo";
            btnSelecionarArquivo.UseVisualStyleBackColor = true;
            btnSelecionarArquivo.Click += btnSelecionarArquivo_Click;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(694, 22);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(94, 29);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(12, 126);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(776, 312);
            txtSaida.TabIndex = 4;
            txtSaida.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(694, 91);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Copiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtSaida);
            Controls.Add(btnConverter);
            Controls.Add(btnSelecionarArquivo);
            Controls.Add(txtArquivo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArquivo;
        private Button btnSelecionarArquivo;
        private Button btnConverter;
        private RichTextBox txtSaida;
        private Button button1;
    }
}