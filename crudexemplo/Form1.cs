namespace crudexemplo
{
    public partial class Form1 : Form

    {
        string nome, sobrenome, curso, RM;
        int ano, idade;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonsalvar_Click(object sender, EventArgs e)
        {
            nome = textboBoxNome.Text;
            sobrenome = textBoxSobrenome.Text;
            curso = textBoxCurso.Text;
            ano = textBoxAno.Text;
            idade = textBoxIdade.Text; 
            RM = textBoxRM.Text;


        }
    }
}
