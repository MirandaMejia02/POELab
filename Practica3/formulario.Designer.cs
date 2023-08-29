namespace Practica3
{
    partial class formulario
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
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Red;
            btnCalcular.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ButtonFace;
            btnCalcular.Location = new Point(210, 110);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(272, 213);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // formulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Name = "formulario";
            Text = "formulario";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
    }
}