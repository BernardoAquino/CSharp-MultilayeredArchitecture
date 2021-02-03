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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string emailUsuario = txtEmail.Text;
                string senhalUsuario = txtSenha.Text;

                ClienteBLL objClienteBLL = new ClienteBLL();

                if (objClienteBLL.ValidarLogin(emailUsuario, senhalUsuario) == true)
                {
                    MessageBox.Show("Acesso Permitido.");
                    int acesso = objClienteBLL.ValidarAcesso(emailUsuario, senhalUsuario);
                    if ( acesso != -1)
                    {
                        MessageBox.Show("Nível de acesso do usuário: " + acesso);
                    }
                }
                else if(objClienteBLL.ValidarLogin(emailUsuario) == false)
                {
                    MessageBox.Show("Email não existente.");
                }
                else
                {
                    MessageBox.Show("Acesso NEGADO. Dados incorretos. Verifique.");
                }
            }catch(FormatException ex)
            {
                MessageBox.Show("Atenção aos valores fornecidos. \n" + ex);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_alterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSenha telaAlterar = new FrmSenha();
            telaAlterar.Show();
        }
    }
}
/*
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string emailUsuario = txtEmail.Text;
                string senhalUsuario = txtSenha.Text;

                ClienteBLL objClienteBLL = new ClienteBLL();

                if (objClienteBLL.ValidarLogin(emailUsuario) == false)
                {
                    MessageBox.Show("Usuário não existente.");
                }
                else
                {
                    int acesso = objClienteBLL.ValidarAcesso(emailUsuario, senhalUsuario); //1 = Admin / 0 = Cliente 

                    if (acesso == 0)
                    {
                        MessageBox.Show("Acesso permitido ao cliente.");
                    }
                    else if (acesso == 1)
                    {
                        MessageBox.Show("Acesso permitido ao administrador.");
                    }
                    else if (acesso == -1)
                    {
                        MessageBox.Show("Senha incorreta!!");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Atenção aos valores fornecidos. \n" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
*/