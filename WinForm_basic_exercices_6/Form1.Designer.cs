namespace WinForm_basic_exercices_6
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
            this.button1 = new System.Windows.Forms.Button();
            this.choosen = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.RadioButton();
            this.white = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // choosen
            // 
            this.choosen.Location = new System.Drawing.Point(45, 239);
            this.choosen.Name = "choosen";
            this.choosen.Size = new System.Drawing.Size(711, 22);
            this.choosen.TabIndex = 5;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(45, 44);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 21);
            this.red.TabIndex = 7;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // white
            // 
            this.white.AutoSize = true;
            this.white.Location = new System.Drawing.Point(45, 135);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(65, 21);
            this.white.TabIndex = 8;
            this.white.TabStop = true;
            this.white.Text = "White";
            this.white.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(45, 89);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(57, 21);
            this.blue.TabIndex = 9;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.white);
            this.Controls.Add(this.red);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choosen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox choosen;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton white;
        private System.Windows.Forms.RadioButton blue;
    }
}

