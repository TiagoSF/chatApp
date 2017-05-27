using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatApp
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {

        public Login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

          
        }


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            if(nicknameInput.TextLength > 0) {
                this.Hide();
                ChatMenu chatMenu = new ChatMenu(nicknameInput.Text);
                chatMenu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Entre com um nickname válido");
            }
        }
           

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void nicknameInput_Click(object sender, EventArgs e)
        {

        }

    }
}
