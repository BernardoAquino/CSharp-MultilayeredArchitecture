using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ProjetoCamadas3A44
{
    public partial class FrmSenha : Form
    {
        public FrmSenha()
        {
            InitializeComponent();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senhaNova = txtSenhaNova.Text;
            string confirmaSenha = txtConfirmaSenha.Text;

            ClienteBLL objBLL = new ClienteBLL();

            if(objBLL.ValidarLogin(email) == false)
            {
                MessageBox.Show("O email informado não existe.");
            }
            else
            {
                if (senhaNova == confirmaSenha)
                {
                    objBLL.AlterarSenha(email, senhaNova);
                    MessageBox.Show("Senha alterada com sucesso.");
                }
                else
                {
                    MessageBox.Show("As senhas informadas estão diferentes.");
                }
            }
        }
    }
}
