namespace WinForm_basic_exercices_10
{
    partial class Form1
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
            this.barra = new System.Windows.Forms.HScrollBar();
            this.porcentaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(60, 74);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(649, 21);
            this.barra.TabIndex = 0;
            this.barra.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // porcentaje
            // 
            this.porcentaje.Location = new System.Drawing.Point(323, 197);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(100, 22);
            this.porcentaje.TabIndex = 1;
            this.porcentaje.TextChanged += new System.EventHandler(this.porcentaje_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.barra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar barra;
        private System.Windows.Forms.TextBox porcentaje;
    }
}

