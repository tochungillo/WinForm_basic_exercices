namespace WinForm_basic_exercices_7
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
            this.colors = new System.Windows.Forms.ComboBox();
            this.choosen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // colors
            // 
            this.colors.FormattingEnabled = true;
            this.colors.Items.AddRange(new object[] {
            "red",
            "blue",
            "green",
            "yellow",
            "purple"});
            this.colors.Location = new System.Drawing.Point(329, 139);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(121, 24);
            this.colors.TabIndex = 0;
            this.colors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // choosen
            // 
            this.choosen.Location = new System.Drawing.Point(95, 244);
            this.choosen.Name = "choosen";
            this.choosen.Size = new System.Drawing.Size(611, 22);
            this.choosen.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choosen);
            this.Controls.Add(this.colors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox colors;
        private System.Windows.Forms.TextBox choosen;
    }
}

