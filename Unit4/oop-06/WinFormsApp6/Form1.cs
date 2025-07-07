using Starwars.Core.Entidades;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jedi = new Jedi
            {
                JediId = 1,
                Name = "Luke Skywalker"
            };

            label1.Text = $"Hello, {jedi.Name}!";
        }
    }
}
