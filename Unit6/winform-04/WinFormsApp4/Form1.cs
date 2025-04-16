using Starwars.Core.Negocio;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss.fffffff");
        }

        private void btnUsuariosBuscar_Click(object sender, EventArgs e)
        {
            var usuarioNegocio = new UsuarioNegocio();
            var usuarios = usuarioNegocio.Listar();

            listUsuarios.Items.Clear();

            foreach (var u in usuarios)
            {
                listUsuarios.Items.Add($"{u.Nombre} {u.Apellido}");
            }
        }

    }
}
