namespace EncryptionAplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCaesar_Click(object sender, EventArgs e)
        {
            Caesar caesar = new Caesar();
            caesar.ShowDialog();
        }

        private void btnPolybius_Click(object sender, EventArgs e)
        {
            Polybius polybius = new Polybius();
            polybius.ShowDialog();
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            Vigenere vigenere = new Vigenere();
            vigenere.ShowDialog();
        }
    }
}
