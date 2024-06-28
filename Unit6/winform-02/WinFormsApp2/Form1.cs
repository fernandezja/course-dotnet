namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblTitle.Text = txtSearch.Text;
        }

        private void btnSearchSuperClick(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            lblTitle2.Text = txtSearch.Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblMousePosition.Text = $"x={e.X} y={e.Y}";
        }

        public string 
        

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Int32 count = 0;

            if (Int32.TryParse(txtCount.Text, out count))
            {
                for (int i = 0; i < count; i++) { 
                    var chk = new CheckBox();
                    chk.Text = $"Item {i}";
                    chk.Location = new Point(0, 20*i);

                    chk.Click += Chk_Click;

                    panel1.Controls.Add(chk); 
                }

            }
            else {
                MessageBox.Show("Ingrese un numero valido");
            }
        }

        private void Chk_Click(object? sender, EventArgs e)
        {
            lblTitle.Text = ((CheckBox)sender).Text;
        }
    }
}
