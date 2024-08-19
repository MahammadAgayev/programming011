namespace _41.forms
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
            btnClickMe = new Button();
            lblHelloWorld = new Label();
            btnThanos = new Button();
            lblTextOfFortune = new Label();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.Location = new Point(118, 218);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(94, 29);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += btnClickMe_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Font = new Font("Calibri", 24F, FontStyle.Italic, GraphicsUnit.Point);
            lblHelloWorld.Location = new Point(68, 49);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(213, 49);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "Hello World";
            lblHelloWorld.Visible = false;
            // 
            // btnThanos
            // 
            btnThanos.Location = new Point(383, 218);
            btnThanos.Name = "btnThanos";
            btnThanos.Size = new Size(94, 29);
            btnThanos.TabIndex = 2;
            btnThanos.Text = "Thanos";
            btnThanos.UseVisualStyleBackColor = true;
            btnThanos.Click += btnThanos_Click;
            // 
            // lblTextOfFortune
            // 
            lblTextOfFortune.AutoSize = true;
            lblTextOfFortune.Font = new Font("Calibri", 24F, FontStyle.Italic, GraphicsUnit.Point);
            lblTextOfFortune.Location = new Point(383, 49);
            lblTextOfFortune.Name = "lblTextOfFortune";
            lblTextOfFortune.Size = new Size(121, 49);
            lblTextOfFortune.TabIndex = 3;
            lblTextOfFortune.Text = "label1";
            lblTextOfFortune.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 339);
            Controls.Add(lblTextOfFortune);
            Controls.Add(btnThanos);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickMe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickMe;
        private Label lblHelloWorld;
        private Button btnThanos;
        private Label lblTextOfFortune;
    }
}
