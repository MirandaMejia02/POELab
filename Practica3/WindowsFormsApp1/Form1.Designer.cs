namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.HoraBox = new System.Windows.Forms.ComboBox();
            this.HoraFinBox = new System.Windows.Forms.ComboBox();
            this.HorarioBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HoraBox
            // 
            this.HoraBox.FormattingEnabled = true;
            this.HoraBox.Location = new System.Drawing.Point(377, 68);
            this.HoraBox.Name = "HoraBox";
            this.HoraBox.Size = new System.Drawing.Size(237, 24);
            this.HoraBox.TabIndex = 0;
            // 
            // HoraFinBox
            // 
            this.HoraFinBox.FormattingEnabled = true;
            this.HoraFinBox.Location = new System.Drawing.Point(74, 135);
            this.HoraFinBox.Name = "HoraFinBox";
            this.HoraFinBox.Size = new System.Drawing.Size(203, 24);
            this.HoraFinBox.TabIndex = 1;
            // 
            // HorarioBox
            // 
            this.HorarioBox.FormattingEnabled = true;
            this.HorarioBox.Location = new System.Drawing.Point(377, 135);
            this.HorarioBox.Name = "HorarioBox";
            this.HorarioBox.Size = new System.Drawing.Size(237, 24);
            this.HorarioBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(44, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(681, 180);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 24);
            this.textBox1.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(116, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 43);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "button1";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HorarioBox);
            this.Controls.Add(this.HoraFinBox);
            this.Controls.Add(this.HoraBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HoraBox;
        private System.Windows.Forms.ComboBox HoraFinBox;
        private System.Windows.Forms.ComboBox HorarioBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
    }
}

