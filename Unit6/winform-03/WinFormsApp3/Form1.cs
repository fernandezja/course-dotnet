namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitCombo();
        }

        private void InitCombo()
        {
            comboBox1.Items.Clear();

            for (int i = 0; i < 50; i++)
            {
                comboBox1.Items.Add($"Item {i}");
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = string.Empty;

            if (comboBox1.SelectedItem is not null)
            {
                itemSeleccionado = comboBox1.SelectedItem.ToString();
            }
               

            label1.Text = $"{DateTime.Now.ToLongTimeString()} - {itemSeleccionado}";
        }
    }
}
