namespace cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            valorFinal.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();



            double aquisicao = Convert.ToDouble(textBox2.Text);
            double lucro = Convert.ToDouble(textBox1.Text);
            double venda = 0;

            Cadastro c = new Cadastro();

            c.Cadastrar(aquisicao, lucro, venda);
            valorFinal.Text = venda.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            valorFinal.Text = "";
        }
    }
}