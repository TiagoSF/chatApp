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
            this.buttonNovaConversa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelPessoasOnline = new MaterialSkin.Controls.MaterialLabel();
            this.listViewPessoasOnline = new System.Windows.Forms.ListView();
            this.listViewSalasDoUsuario = new System.Windows.Forms.ListView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
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
            // buttonNovaConversa
            // 
            this.buttonNovaConversa.Depth = 0;
            this.buttonNovaConversa.Location = new System.Drawing.Point(534, 367);
            this.buttonNovaConversa.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNovaConversa.Name = "buttonNovaConversa";
            this.buttonNovaConversa.Primary = true;
            this.buttonNovaConversa.Size = new System.Drawing.Size(120, 46);
            this.buttonNovaConversa.TabIndex = 4;
            this.buttonNovaConversa.Text = "Nova Conversa";
            this.buttonNovaConversa.UseVisualStyleBackColor = true;
            this.buttonNovaConversa.Click += new System.EventHandler(this.buttonNovaConversa_Click);
            // 
            // labelPessoasOnline
            // 
            this.labelPessoasOnline.AutoSize = true;
            this.labelPessoasOnline.Depth = 0;
            this.labelPessoasOnline.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPessoasOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPessoasOnline.Location = new System.Drawing.Point(20, 85);
            this.labelPessoasOnline.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPessoasOnline.Name = "labelPessoasOnline";
            this.labelPessoasOnline.Size = new System.Drawing.Size(113, 19);
            this.labelPessoasOnline.TabIndex = 5;
            this.labelPessoasOnline.Text = "Pessoas Online";
            this.labelPessoasOnline.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // listViewPessoasOnline
            // 
            this.listViewPessoasOnline.Location = new System.Drawing.Point(15, 114);
            this.listViewPessoasOnline.MultiSelect = false;
            this.listViewPessoasOnline.Name = "listViewPessoasOnline";
            this.listViewPessoasOnline.Size = new System.Drawing.Size(124, 275);
            this.listViewPessoasOnline.TabIndex = 6;
            this.listViewPessoasOnline.UseCompatibleStateImageBehavior = false;
            // 
            // listViewSalasDoUsuario
            // 
            this.listViewSalasDoUsuario.Location = new System.Drawing.Point(171, 113);
            this.listViewSalasDoUsuario.Name = "listViewSalasDoUsuario";
            this.listViewSalasDoUsuario.Size = new System.Drawing.Size(482, 229);
            this.listViewSalasDoUsuario.TabIndex = 7;
            this.listViewSalasDoUsuario.UseCompatibleStateImageBehavior = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(181, 85);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Salas";
            // 
            // ChatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 425);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.listViewSalasDoUsuario);
            this.Controls.Add(this.listViewPessoasOnline);
            this.Controls.Add(this.labelPessoasOnline);
            this.Controls.Add(this.buttonNovaConversa);
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
        private MaterialSkin.Controls.MaterialRaisedButton buttonNovaConversa;
        private MaterialSkin.Controls.MaterialLabel labelPessoasOnline;
        private System.Windows.Forms.ListView listViewPessoasOnline;
        private System.Windows.Forms.ListView listViewSalasDoUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}