namespace Even_Academ
{
    public partial class Form1 : Form
    {
        private Cadastro<Usuario> _cadastroUsuarios = new Cadastro<Usuario>();
        private Cadastro<Evento> _cadastroEventos = new Cadastro<Evento>();
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Evento> listaEventos = new List<Evento>();
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmCadastroUsuario(_cadastroUsuarios);
            form.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmCadastroEvento(_cadastroEventos, _cadastroUsuarios);
            form.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmListarParticipantes(listaEventos);
            form.ShowDialog();

        }

        private void inscreverEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmInscreverEvento(listaUsuarios, listaEventos);
            form.ShowDialog();

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmListarEventos(listaEventos);
            form.ShowDialog();



        }


    }
}
