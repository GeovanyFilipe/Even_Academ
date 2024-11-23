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
    public partial class FrmCadastroEvento : Form
    {
        private Cadastro<Evento> _cadastroEventos;
        private Cadastro<Usuario> _cadastroUsuarios;

        public FrmCadastroEvento(Cadastro<Evento> cadastroEventos, Cadastro<Usuario> cadastroUsuarios)
        {
            InitializeComponent();
            _cadastroEventos = cadastroEventos;
            _cadastroUsuarios = cadastroUsuarios;
            CarregarProfessores();
        }

        private void CarregarProfessores()
        {
            var professores = _cadastroUsuarios.Listar().Where(u => u.Tipo == "Professor").ToList();
            comboBox1.DataSource = professores;
            comboBox1.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var evento = new Evento
            {
                Titulo = textBox1.Text,
                Descricao = textBox2.Text,
                DataHora = dateTimePicker1.Value,
                Criador = comboBox1.Text,
            };

            _cadastroEventos.Adicionar(evento);
            MessageBox.Show("Evento cadastrado com sucesso!");
            this.Close();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
