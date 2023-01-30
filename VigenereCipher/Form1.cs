namespace VigenereCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            textInput.Text = result.Text;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var cipher = new Cipher();
            
            string key = cipher.ConvertKey(textInput.Text, keyInput.Text);

             result.Text = cipher.Encrypt(textInput.Text, key);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var cipher = new Cipher();

            string key = cipher.ConvertKey(textInput.Text, keyInput.Text);
            
            result.Text = cipher.Decrypt(textInput.Text, key);
        }
    }
}