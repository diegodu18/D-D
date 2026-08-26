namespace ScreenGame
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExitGame;
       
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
 
            this.SuspendLayout();
            // 
            // btnNuevaPartida
            // 
            this.btnNewGame.Location = new System.Drawing.Point(50, 30);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 40);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.Tag = "NewGame";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnCargarPartida
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(50, 90);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(200, 40);
            this.btnLoadGame.TabIndex = 1;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.Tag = "LoadGame";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(50, 150);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 40);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Tag = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalir
            // 
            this.btnExitGame.Location = new System.Drawing.Point(50, 210);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(200, 40);
            this.btnExitGame.TabIndex = 3;
            this.btnExitGame.Text = "Exit";
            this.btnExitGame.Tag = "Exit";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExitGame);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Tag = "AppTitle";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

