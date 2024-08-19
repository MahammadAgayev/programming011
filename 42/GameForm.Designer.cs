namespace _42
{
    partial class GameForm
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
            pnlGameBoard = new Panel();
            lblGameOver = new Label();
            pnlGameBoard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGameBoard
            // 
            pnlGameBoard.BackColor = SystemColors.ButtonShadow;
            pnlGameBoard.Controls.Add(lblGameOver);
            pnlGameBoard.Location = new Point(37, 39);
            pnlGameBoard.Name = "pnlGameBoard";
            pnlGameBoard.Size = new Size(468, 626);
            pnlGameBoard.TabIndex = 0;
            pnlGameBoard.Paint += pnlGameBoard_Paint;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Calibri", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            lblGameOver.ForeColor = Color.Red;
            lblGameOver.Location = new Point(106, 219);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(225, 54);
            lblGameOver.TabIndex = 1;
            lblGameOver.Text = "Game Over";
            lblGameOver.Visible = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 707);
            Controls.Add(pnlGameBoard);
            Name = "GameForm";
            Text = "Snake Game";
            PreviewKeyDown += GameForm_PreviewKeyDown;
            pnlGameBoard.ResumeLayout(false);
            pnlGameBoard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGameBoard;
        private Label lblGameOver;
    }
}
