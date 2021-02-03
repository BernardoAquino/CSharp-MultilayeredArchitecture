using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCamadas3A44.DTO
{
    class ClienteDTO
    {
        private int id;
        private string nome, endereco, uf, telefone, email,  senha;

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
                else
                {
                    throw new Exception("Coloque um id correto!");
                }
            }
        }

        public string Nome
        {
            get { return this.nome; }
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
        }

        public string Endereco
        {
            get { return this.endereco; }
            set
            {
                if (value != string.Empty)
                {
                    this.endereco = value;
                }
                else
                {
                    throw new Exception("O endereco deve ser obrigatoriamente preenchido.");
                }
            }
        }

        public string Uf
        {
            get { return this.uf; }
            set
            {
                if (value != string.Empty && value.Length == 2)
                {
                    this.uf = value;
                }
                else
                {
                    throw new Exception("A UF deve ser preenchido da forma correta.");
                }
            }
        }

        public string Telefone
        {
            get { return this.telefone; }
            set
            {
                if (value != string.Empty)
                {
                    this.telefone = value;
                }
                else
                {
                    throw new Exception("O telefone deve ser obrigatoriamente preenchido.");
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("O e-mail deve ser obrigatoriamente preenchido.");
                }
            }
        }

        public string Senha
        {
            get { return this.senha; }
            set
            {
                if (value != string.Empty)
                {
                    this.senha = value;
                }
                else
                {
                    throw new Exception("A senha deve ser obrigatoriamente preenchida.");
                }
            }
        }
    }
}
