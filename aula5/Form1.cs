namespace aula5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Time obj = new Time();
        Time[] v = new Time[10];
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Time timinho = new Time("Brasil", "SP");
            MessageBox.Show("Nome: " + timinho.Nome + "\nPaís: " + timinho.Pais + "\nEstado: " + timinho.Estado + "\nTítulos: " + timinho.Titulo);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPesqu_Click(object sender, EventArgs e)
        {
          
        }

        private void btnGrav_Click_1(object sender, EventArgs e)
        {
  
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                    obj.Nome = txtNome.Text;
                    obj.Pais = txtPais.Text;
                    obj.Estado = txtEstado.Text;
                    obj.Titulo = Convert.ToInt32(txtTitulo.Text);
                    v[i] = obj;
                    i++;
            }
            else
            {
                MessageBox.Show("Não é possível gravar: ");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           for(int j = 0; j < 10; j++)
            {
                if (v[j].Equals(txtNome.Text))
                {
                    txtEstado.Text = v[j].Estado;
                    txtPais.Text = v[j].Pais;
                    txtTitulo.Text = v[j].Titulo.ToString();
                    j = 9;
                }
                else
                {
                    if (j == 9) MessageBox.Show("Time não encontrado!!!!!!!!!!!");
                }
            }
        }
    }
}