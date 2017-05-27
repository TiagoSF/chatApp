namespace chatApp
{
    partial class Login
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
            this.LoginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.nicknameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Depth = 0;
            this.LoginButton.Location = new System.Drawing.Point(149, 252);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = true;
            this.LoginButton.Size = new System.Drawing.Size(92, 32);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // nicknameInput
            // 
            this.nicknameInput.Depth = 0;
            this.nicknameInput.Hint = "Escreva seu Nickname";
            this.nicknameInput.Location = new System.Drawing.Point(96, 146);
            this.nicknameInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.nicknameInput.Name = "nicknameInput";
            this.nicknameInput.PasswordChar = '\0';
            this.nicknameInput.SelectedText = "";
            this.nicknameInput.SelectionLength = 0;
            this.nicknameInput.SelectionStart = 0;
            this.nicknameInput.Size = new System.Drawing.Size(204, 23);
            this.nicknameInput.TabIndex = 3;
            this.nicknameInput.UseSystemPasswordChar = false;
            this.nicknameInput.Click += new System.EventHandler(this.nicknameInput_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 336);
            this.Controls.Add(this.nicknameInput);
            this.Controls.Add(this.LoginButton);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton LoginButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField nicknameInput;
    }
}

