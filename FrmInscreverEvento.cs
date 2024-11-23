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
    public partial class FrmInscreverEvento : Form
    {
        private List<Usuario> _usuarios;
        private List<Evento> _eventos;
        public FrmInscreverEvento(List<Usuario> usuarios, List<Evento> eventos)
        {
            InitializeComponent();
            _usuarios = usuarios.Where(u => u.Tipo == "Estudante").ToList(); // Apenas estudantes
            _eventos = eventos;
            CarregarDados();
        }
        public void CarregarDados()
        {
            comboBox1.DataSource = _usuarios;
            comboBox2.DisplayMember = "Name";

            comboBox1.DataSource= _eventos;
            comboBox2.DisplayMember = "Titulo";


        }
        private void FrmInscreverEvento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var estudanteSelecionado = comboBox1.SelectedItem as Usuario;
            var eventoSelecionado = comboBox2.SelectedItem as Evento;


            if (eventoSelecionado.Participantes.Any(p => p.Email == estudanteSelecionado.Email))
            {
                MessageBox.Show("O estudante já está inscrito neste evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            eventoSelecionado.Participantes.Add(estudanteSelecionado);
            MessageBox.Show("Inscrição realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
