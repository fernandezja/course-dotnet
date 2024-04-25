using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Starwars.Core.Business;
using Starwars.Core.Business.Interfaces;
using Starwars.Core.Entities;
using System.Linq;

namespace Starwars.App2
{
    public partial class Form1 : Form
    {
        private IJedisBusiness _jediBusiness;
        private ILogger _logger;

        private Jedi _jediSeleccionado = null;

        public Form1(IJedisBusiness jedisBusiness,
                     ILogger logger)
        {
            //_jediBusiness = new JedisBusiness();
            _jediBusiness = jedisBusiness;
            _logger = logger;

            _logger.LogInformation("DEMO DEMO");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {

            var jedis = _jediBusiness.GetAll();

            dataGridView1.DataSource = jedis;
            dataGridView1.AutoGenerateColumns = true;


            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = jedis;
            dataGridView2.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                _jediSeleccionado  = (Jedi)row.DataBoundItem;

                label1.Text = _jediSeleccionado.Name;
            }
            else
            {
                label1.Text = "Sin seleccion...";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = Program.ServiceProvider.GetRequiredService<Form2>();
            //_form2.Jedi = _jediSeleccionado;

            form2.SetJedi(_jediSeleccionado);
            form2.Show();

        }
    }
}
