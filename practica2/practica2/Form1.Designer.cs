namespace practica2
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
            btncalcular = new Button();
            txtMonto = new TextBox();
            txtPorcentaje = new TextBox();
            label2 = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 52);
            label1.Name = "label1";
            label1.Size = new Size(216, 26);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un monto inicial";
            // 
            // btncalcular
            // 
            btncalcular.BackColor = Color.FromArgb(128, 255, 255);
            btncalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btncalcular.Location = new Point(186, 219);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(93, 40);
            btncalcular.TabIndex = 1;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(122, 81);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(239, 23);
            txtMonto.TabIndex = 2;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(122, 164);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(239, 23);
            txtPorcentaje.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(145, 138);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 4;
            label2.Text = "Ingrese un Porcentaje";
            // 
            // lblMensaje
            // 
            lblMensaje.Location = new Point(186, 288);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(100, 23);
            lblMensaje.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(488, 404);
            Controls.Add(lblMensaje);
            Controls.Add(label2);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtMonto);
            Controls.Add(btncalcular);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncalcular;
        private TextBox txtMonto;
        private TextBox txtPorcentaje;
        private Label label2;
        private Label lblMensaje;
    }
}