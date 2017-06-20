namespace chatApp
{
    partial class Chat
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
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listViewMenbrosNaSala = new System.Windows.Forms.ListView();
            this.buttonVoltar = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonSairDaSala = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonAdicionarUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxConversa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(1, 315);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(565, 50);
            this.materialTabSelector2.TabIndex = 4;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Depth = 0;
            this.buttonEnviar.Location = new System.Drawing.Point(479, 331);
            this.buttonEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Primary = true;
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 6;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            // 
            // listViewMenbrosNaSala
            // 
            this.listViewMenbrosNaSala.Location = new System.Drawing.Point(1, 68);
            this.listViewMenbrosNaSala.MultiSelect = false;
            this.listViewMenbrosNaSala.Name = "listViewMenbrosNaSala";
            this.listViewMenbrosNaSala.Size = new System.Drawing.Size(126, 241);
            this.listViewMenbrosNaSala.TabIndex = 7;
            this.listViewMenbrosNaSala.UseCompatibleStateImageBehavior = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.AutoSize = true;
            this.buttonVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonVoltar.Depth = 0;
            this.buttonVoltar.Location = new System.Drawing.Point(490, 26);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Primary = false;
            this.buttonVoltar.Size = new System.Drawing.Size(64, 36);
            this.buttonVoltar.TabIndex = 8;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonSairDaSala
            // 
            this.buttonSairDaSala.AutoSize = true;
            this.buttonSairDaSala.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSairDaSala.Depth = 0;
            this.buttonSairDaSala.Location = new System.Drawing.Point(381, 26);
            this.buttonSairDaSala.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSairDaSala.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSairDaSala.Name = "buttonSairDaSala";
            this.buttonSairDaSala.Primary = false;
            this.buttonSairDaSala.Size = new System.Drawing.Size(101, 36);
            this.buttonSairDaSala.TabIndex = 9;
            this.buttonSairDaSala.Text = "Sair da sala";
            this.buttonSairDaSala.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarUsuario
            // 
            this.buttonAdicionarUsuario.AutoSize = true;
            this.buttonAdicionarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdicionarUsuario.Depth = 0;
            this.buttonAdicionarUsuario.Location = new System.Drawing.Point(229, 26);
            this.buttonAdicionarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdicionarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdicionarUsuario.Name = "buttonAdicionarUsuario";
            this.buttonAdicionarUsuario.Primary = false;
            this.buttonAdicionarUsuario.Size = new System.Drawing.Size(144, 36);
            this.buttonAdicionarUsuario.TabIndex = 10;
            this.buttonAdicionarUsuario.Text = "Adicionar usuario";
            this.buttonAdicionarUsuario.UseVisualStyleBackColor = true;
            // 
            // textBoxConversa
            // 
            this.textBoxConversa.Location = new System.Drawing.Point(135, 69);
            this.textBoxConversa.Name = "textBoxConversa";
            this.textBoxConversa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConversa.Size = new System.Drawing.Size(418, 20);
            this.textBoxConversa.TabIndex = 11;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 363);
            this.Controls.Add(this.textBoxConversa);
            this.Controls.Add(this.buttonAdicionarUsuario);
            this.Controls.Add(this.buttonSairDaSala);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.listViewMenbrosNaSala);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialTabSelector2);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonEnviar;
        private System.Windows.Forms.ListView listViewMenbrosNaSala;
        private MaterialSkin.Controls.MaterialFlatButton buttonVoltar;
        private MaterialSkin.Controls.MaterialFlatButton buttonSairDaSala;
        private MaterialSkin.Controls.MaterialFlatButton buttonAdicionarUsuario;
        private System.Windows.Forms.TextBox textBoxConversa;
    }
}