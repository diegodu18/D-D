namespace ScreenGame
{
    partial class Settings
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";
            this.lblTitle.Tag = "Settings";
            // 
            // cboLang
            // 
            this.cboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Location = new System.Drawing.Point(20, 50);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(200, 24);
            this.cboLang.TabIndex = 1;
            this.cboLang.SelectedIndexChanged += new System.EventHandler(this.cboLang_SelectedIndexChanged);
            this.cboLang.Tag = "";
            //
            // btnOK
            //
            this.btnOK.Location = new System.Drawing.Point(240, 50);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.Tag = "OK";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(20, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.Tag = "Back";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 150);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboLang);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Tag = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
    }
}
