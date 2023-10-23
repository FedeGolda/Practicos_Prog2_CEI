namespace RelojDigital
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
            components = new System.ComponentModel.Container();
            labelHora = new Label();
            labelFecha = new Label();
            horaFecha = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point);
            labelHora.ForeColor = SystemColors.MenuHighlight;
            labelHora.Location = new Point(93, 21);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(273, 106);
            labelHora.TabIndex = 0;
            labelHora.Text = "label1";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.ForeColor = SystemColors.ControlDarkDark;
            labelFecha.Location = new Point(83, 136);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(273, 106);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "label1";
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 300);
            Controls.Add(labelFecha);
            Controls.Add(labelHora);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHora;
        private Label labelFecha;
        private System.Windows.Forms.Timer horaFecha;
    }
}