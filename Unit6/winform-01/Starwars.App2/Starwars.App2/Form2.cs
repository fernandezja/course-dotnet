using Microsoft.Extensions.Logging;
using Starwars.Core.Business.Interfaces;
using Starwars.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starwars.App2
{
    public partial class Form2 : Form
    {
        private IJedisBusiness _jediBusiness;
        private ILogger _logger;

        public Jedi Jedi { get; set; }

        public Form2(IJedisBusiness jedisBusiness,
                     ILogger logger)
        {
            //_jediBusiness = new JedisBusiness();
            _jediBusiness = jedisBusiness;
            _logger = logger;

            InitializeComponent();
        }


        public void SetJedi(Jedi jedi)
        {
            Jedi = jedi;

        }

        public void CargarDatos()
        {
            if (Jedi is not null)
            {
                txtName.Text = Jedi.Name;

             

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar
            //Jedi.Name = txtName.Text;   

            this.Close();
        }
    }
}
