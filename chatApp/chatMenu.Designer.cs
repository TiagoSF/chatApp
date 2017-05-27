namespace chatApp
{
    partial class ChatMenu
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
            this.nicknameDisplay = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.novaConversaButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // nicknameDisplay
            // 
            this.nicknameDisplay.AutoSize = true;
            this.nicknameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.nicknameDisplay.Depth = 0;
            this.nicknameDisplay.Font = new System.Drawing.Font("Roboto", 11F);
            this.nicknameDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nicknameDisplay.Location = new System.Drawing.Point(534, 34);
            this.nicknameDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.nicknameDisplay.Name = "nicknameDisplay";
            this.nicknameDisplay.Size = new System.Drawing.Size(0, 19);
            this.nicknameDisplay.TabIndex = 1;
            this.nicknameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(443, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Bem Vindo,";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // novaConversaButton
            // 
            this.novaConversaButton.Depth = 0;
            this.novaConversaButton.Location = new System.Drawing.Point(534, 367);
            this.novaConversaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.novaConversaButton.Name = "novaConversaButton";
            this.novaConversaButton.Primary = true;
            this.novaConversaButton.Size = new System.Drawing.Size(120, 46);
            this.novaConversaButton.TabIndex = 4;
            this.novaConversaButton.Text = "Nova Conversa";
            this.novaConversaButton.UseVisualStyleBackColor = true;
            // 
            // ChatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 425);
            this.Controls.Add(this.novaConversaButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nicknameDisplay);
            this.Name = "ChatMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.chatMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel nicknameDisplay;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton novaConversaButton;
    }
}