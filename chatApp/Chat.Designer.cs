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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
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
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(479, 331);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Enviar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 363);
            this.Controls.Add(this.materialRaisedButton1);
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
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}