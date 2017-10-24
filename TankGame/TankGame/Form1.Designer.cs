namespace TankGame
{
    partial class TankGame
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
            this.gameArea = new System.Windows.Forms.Panel();
            this.playerTank = new System.Windows.Forms.PictureBox();
            this.landBar = new System.Windows.Forms.Panel();
            this.gameTitle = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTank)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.Controls.Add(this.playerTank);
            this.gameArea.Controls.Add(this.landBar);
            this.gameArea.Controls.Add(this.gameTitle);
            this.gameArea.Controls.Add(this.startBtn);
            this.gameArea.Location = new System.Drawing.Point(0, 0);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(1233, 595);
            this.gameArea.TabIndex = 0;
            this.gameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.gameArea_Paint);
            // 
            // playerTank
            // 
            this.playerTank.BackColor = System.Drawing.Color.Red;
            this.playerTank.Location = new System.Drawing.Point(283, 342);
            this.playerTank.Name = "playerTank";
            this.playerTank.Size = new System.Drawing.Size(132, 121);
            this.playerTank.TabIndex = 4;
            this.playerTank.TabStop = false;
            // 
            // landBar
            // 
            this.landBar.AutoSize = true;
            this.landBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.landBar.Location = new System.Drawing.Point(0, 469);
            this.landBar.Name = "landBar";
            this.landBar.Size = new System.Drawing.Size(1233, 125);
            this.landBar.TabIndex = 3;
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameTitle.Location = new System.Drawing.Point(292, 89);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(668, 145);
            this.gameTitle.TabIndex = 2;
            this.gameTitle.Text = "A TANK GAME";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(496, 357);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(235, 82);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "START GAME";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.startBtn_Paint);
            // 
            // TankGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 595);
            this.Controls.Add(this.gameArea);
            this.Name = "TankGame";
            this.Text = "TankGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TankGame_KeyDown);
            this.gameArea.ResumeLayout(false);
            this.gameArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTank)).EndInit();
            this.ResumeLayout(false);

            this.KeyPreview = true;

        }

        #endregion

        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel landBar;
        private System.Windows.Forms.PictureBox playerTank;
        private System.Windows.Forms.Label gameTitle;
    }
}

