using Starwars.Core.Business;
using Starwars.Core.Entities;

namespace Starwars.Apps.WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var jediBusiness = new JediBusiness();

            var jedis = jediBusiness.GetAll();

            foreach (var jedi in jedis)
            {
                listBox1.Items.Add($"JediId: {jedi.JediId}, Name: {jedi.Name}, Height: {jedi.Height}");

                //Console.WriteLine($"JediId: {jedi.JediId}, Name: {jedi.Name}, Height: {jedi.Height}");

            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;

            if (item is not null)
            {

                label1.Text = item.ToString();
            }
        }
    }
}
