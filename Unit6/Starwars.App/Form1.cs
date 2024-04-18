namespace Starwars.App
{
    public partial class FormInit : Form
    {
        public FormInit()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

        //    var ancho = Int32.Parse(txtAncho.Text);
        //    var alto = Int32.Parse(txtAlto.Text);

        //    this.Width = ancho;
        //    this.Height = alto;

            var tieneError = false;

            if (Int32.TryParse(txtAncho.Text, out var ancho))
            {
                this.Width = ancho;
            }
            else
            {
                tieneError = true;
                lblMensajeError.Text = "⚠️ El valor ingresado del ancho no es un número válido";
            };


            if (Int32.TryParse(txtAlto.Text, out var alto))
            {
                this.Height = alto;
            }
            else
            {
                tieneError = true;
                lblMensajeError.Text = "⚠️ El valor ingresado del alto no es un número válido";

            };




            if (double.TryParse(txtOpacity.Text, out var opacity))
            {
                this.Opacity = opacity;
            }
            else
            {
                tieneError = true;
                lblMensajeError.Text = "⚠️ El valor ingresado de la opacidad no es un número válido";

            };

            //lblMensajeError.Visible = tieneError;

            if (tieneError)
            {
                lblMensajeError.Visible = true;
            }
            else
            {
                lblMensajeError.Visible = false;
            }

            GenerarCheckbox(70);
        }

        private void GenerarCheckbox(int cantidad)
        {

            for (int i = 1; i <= cantidad; i++)
            {
                var chk = new CheckBox
                {
                    Text = $"Option {i}",
                    Location = new Point(3, (i * 20))
                };
                panel1.Controls.Add(chk);
            }

        }

        private void FormInit_Load(object sender, EventArgs e)
        {
            lblMensajeError.Visible = false;
        }
    }
}
