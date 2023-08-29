namespace Practica3
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
            label1 = new Label();
            txtNumero = new TextBox();
            label2 = new Label();
            txtLetra = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(105, 53);
            label1.Name = "label1";
            label1.Size = new Size(343, 29);
            label1.TabIndex = 0;
            label1.Text = "ESCRIBA UN NUMERO";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(35, 85);
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(488, 34);
            txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(35, 138);
            label2.Name = "label2";
            label2.Size = new Size(502, 31);
            label2.TabIndex = 2;
            label2.Text = "ESCRIBA UNA LETRA O CARACTER";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(35, 172);
            txtLetra.Multiline = true;
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(488, 34);
            txtLetra.TabIndex = 3;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnValidar.Location = new Point(162, 237);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(184, 41);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "VALIDAR";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(573, 340);
            Controls.Add(btnValidar);
            Controls.Add(txtLetra);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtLetra;
        private Button btnValidar;
    }
}