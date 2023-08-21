namespace proyecto1
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
            num = new TextBox();
            label2 = new Label();
            Letra = new TextBox();
            inputbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(59, 25);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 0;
            label1.Text = "Escriba un numero";
            // 
            // num
            // 
            num.Location = new Point(59, 55);
            num.Name = "num";
            num.Size = new Size(183, 27);
            num.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(59, 98);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 2;
            label2.Text = "Escriba una letra o caracter";
            // 
            // Letra
            // 
            Letra.Location = new Point(59, 134);
            Letra.Name = "Letra";
            Letra.Size = new Size(183, 27);
            Letra.TabIndex = 3;
            // 
            // inputbutton
            // 
            inputbutton.Location = new Point(100, 185);
            inputbutton.Name = "inputbutton";
            inputbutton.Size = new Size(94, 29);
            inputbutton.TabIndex = 4;
            inputbutton.Text = "VALIDAR";
            inputbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 319);
            Controls.Add(inputbutton);
            Controls.Add(Letra);
            Controls.Add(label2);
            Controls.Add(num);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num;
        private Label label2;
        private TextBox Letra;
        private Button inputbutton;
    }
}