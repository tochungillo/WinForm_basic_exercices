namespace WinForm_basic_exercices_9
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
            this.numbers = new System.Windows.Forms.ComboBox();
            this.selected = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbers
            // 
            this.numbers.FormattingEnabled = true;
            this.numbers.Location = new System.Drawing.Point(65, 108);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(121, 24);
            this.numbers.TabIndex = 0;
            this.numbers.SelectedIndexChanged += new System.EventHandler(this.numbers_SelectedIndexChanged);
            // 
            // selected
            // 
            this.selected.Location = new System.Drawing.Point(65, 294);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(660, 22);
            this.selected.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Even";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Odd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.numbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox numbers;
        private System.Windows.Forms.TextBox selected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

