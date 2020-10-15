namespace WinForm_basic_exercices_5
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
            this.mouse = new System.Windows.Forms.CheckBox();
            this.cat = new System.Windows.Forms.CheckBox();
            this.dog = new System.Windows.Forms.CheckBox();
            this.choosen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mouse
            // 
            this.mouse.AutoSize = true;
            this.mouse.Location = new System.Drawing.Point(42, 46);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(72, 21);
            this.mouse.TabIndex = 0;
            this.mouse.Text = "Mouse";
            this.mouse.UseVisualStyleBackColor = true;
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Location = new System.Drawing.Point(42, 118);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(51, 21);
            this.cat.TabIndex = 1;
            this.cat.Text = "Cat";
            this.cat.UseVisualStyleBackColor = true;
            // 
            // dog
            // 
            this.dog.AutoSize = true;
            this.dog.Location = new System.Drawing.Point(42, 188);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(56, 21);
            this.dog.TabIndex = 2;
            this.dog.Text = "Dog";
            this.dog.UseVisualStyleBackColor = true;
            // 
            // choosen
            // 
            this.choosen.Location = new System.Drawing.Point(42, 300);
            this.choosen.Name = "choosen";
            this.choosen.Size = new System.Drawing.Size(711, 22);
            this.choosen.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choosen);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.mouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mouse;
        private System.Windows.Forms.CheckBox cat;
        private System.Windows.Forms.CheckBox dog;
        private System.Windows.Forms.TextBox choosen;
        private System.Windows.Forms.Button button1;
    }
}

