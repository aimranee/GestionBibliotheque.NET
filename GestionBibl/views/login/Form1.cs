namespace GestionBibl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUserName.Text=="admin" && textPassword.Text == "1234")
            {
                new PageHome().Show();
                this.Hide();
            }
            else if (textUserName.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe est incorrect");
                textUserName.Clear();
                textPassword.Clear();
                textUserName.Focus();
            }
            else
            {
                MessageBox.Show("Les champs vide!!");
                textUserName.Clear();
                textPassword.Clear();
                textUserName.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
            textUserName.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}