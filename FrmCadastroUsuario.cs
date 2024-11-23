using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Even_Academ
{
    public partial class FrmCadastroUsuario : Form
    {
        private Cadastro<Usuario> _cadastroUsuarios;

        public FrmCadastroUsuario(Cadastro<Usuario> cadastroUsuarios)
        {
            InitializeComponent();
            _cadastroUsuarios = cadastroUsuarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var usuario = new Usuario
            {
                Nome = textBox1.Text,
                Email = textBox2.Text,
                Tipo = comboBox1.SelectedItem.ToString()
            };

            _cadastroUsuarios.Adicionar(usuario);
            MessageBox.Show("Usuário cadastrado com sucesso!");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

