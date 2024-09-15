namespace Aflevering1VidergåendeProgrammering
{
    public partial class Form1 : Form
    {
        public string[] navneArray = new string[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNavn_Click(object sender, EventArgs e)
        {
            string navn = txtBoxNavn.Text;
            int index = Convert.ToInt32(txtBoxPosition.Text);

            if (navn != null)
            {
                navneArray[index] = navn;
            }
        }

        private void listBoxNavne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpdater_Click(object sender, EventArgs e)
        {
            listBoxNavne.Items.Clear();

            for (int i = 0; i < navneArray.Length; i++)
            {

                if (navneArray[i] != null)
                {
                    listBoxNavne.Items.Add(navneArray[i]);
                }
                else
                {
                    break;
                }
            }
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtBoxPosition.Text);
            listBoxNavne.Items.RemoveAt(index);
        }
    }

}
