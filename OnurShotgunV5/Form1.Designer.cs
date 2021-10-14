
namespace OnurShotgunV5
{
    partial class frmShotgun
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
            this.lblShotgun = new System.Windows.Forms.Label();
            this.lblPlayerAmmo = new System.Windows.Forms.Label();
            this.lblComputerAmmo = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lblPlayerMove = new System.Windows.Forms.Label();
            this.lblComputerMove = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShotgun
            // 
            this.lblShotgun.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShotgun.Location = new System.Drawing.Point(12, 9);
            this.lblShotgun.Name = "lblShotgun";
            this.lblShotgun.Size = new System.Drawing.Size(821, 63);
            this.lblShotgun.TabIndex = 0;
            this.lblShotgun.Text = "SHOTGUN GAME";
            this.lblShotgun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerAmmo
            // 
            this.lblPlayerAmmo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAmmo.Location = new System.Drawing.Point(156, 295);
            this.lblPlayerAmmo.Name = "lblPlayerAmmo";
            this.lblPlayerAmmo.Size = new System.Drawing.Size(210, 59);
            this.lblPlayerAmmo.TabIndex = 3;
            this.lblPlayerAmmo.Text = "Player ammo";
            this.lblPlayerAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerAmmo
            // 
            this.lblComputerAmmo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerAmmo.Location = new System.Drawing.Point(442, 295);
            this.lblComputerAmmo.Name = "lblComputerAmmo";
            this.lblComputerAmmo.Size = new System.Drawing.Size(210, 59);
            this.lblComputerAmmo.TabIndex = 4;
            this.lblComputerAmmo.Text = "Computer ammo";
            this.lblComputerAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShoot
            // 
            this.btnShoot.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.Location = new System.Drawing.Point(18, 112);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(100, 37);
            this.btnShoot.TabIndex = 5;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.Location = new System.Drawing.Point(18, 186);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(100, 37);
            this.btnBlock.TabIndex = 6;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(18, 257);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 37);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.BackColor = System.Drawing.Color.OrangeRed;
            this.btnShotgun.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShotgun.ForeColor = System.Drawing.Color.Black;
            this.btnShotgun.Location = new System.Drawing.Point(18, 365);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(100, 37);
            this.btnShotgun.TabIndex = 8;
            this.btnShotgun.Text = "SHOTGUN!";
            this.btnShotgun.UseVisualStyleBackColor = false;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // lblPlayerMove
            // 
            this.lblPlayerMove.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerMove.Location = new System.Drawing.Point(156, 186);
            this.lblPlayerMove.Name = "lblPlayerMove";
            this.lblPlayerMove.Size = new System.Drawing.Size(210, 59);
            this.lblPlayerMove.TabIndex = 9;
            this.lblPlayerMove.Text = "Player move";
            this.lblPlayerMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerMove
            // 
            this.lblComputerMove.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerMove.Location = new System.Drawing.Point(442, 186);
            this.lblComputerMove.Name = "lblComputerMove";
            this.lblComputerMove.Size = new System.Drawing.Size(210, 59);
            this.lblComputerMove.TabIndex = 10;
            this.lblComputerMove.Text = "Computer move";
            this.lblComputerMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(576, 449);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(100, 37);
            this.btnPlayAgain.TabIndex = 11;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitGame.Location = new System.Drawing.Point(707, 449);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(100, 37);
            this.btnQuitGame.TabIndex = 12;
            this.btnQuitGame.Text = "Quit Game";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // frmShotgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 511);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblComputerMove);
            this.Controls.Add(this.lblPlayerMove);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.lblComputerAmmo);
            this.Controls.Add(this.lblPlayerAmmo);
            this.Controls.Add(this.lblShotgun);
            this.Name = "frmShotgun";
            this.Text = "frmShotgun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShotgun;
        private System.Windows.Forms.Label lblPlayerAmmo;
        private System.Windows.Forms.Label lblComputerAmmo;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label lblPlayerMove;
        private System.Windows.Forms.Label lblComputerMove;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuitGame;
    }
}

