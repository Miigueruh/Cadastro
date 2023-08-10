namespace cadastro
{
    public partial class Form1 : Form
    {
        List<Cadastro> lista = new List<Cadastro>();
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

            Cadastro c = new Cadastro();
            c.Id = codigo.Text;
            c.Descricao = descricao.Text;
            c.PrecoAquisicao = Convert.ToDouble(aquisicao.Text);
            c.Lucro = Convert.ToDouble(lucro.Text);
            c.PrecoVenda = (c.PrecoAquisicao * c.Lucro / 100) + c.PrecoAquisicao;
            valorFinal.Text = c.PrecoVenda.ToString();

            lista.Add(c);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = lista;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucro.Text = "";
            aquisicao.Text = "";
            descricao.Text = "";
            codigo.Text = "";
            valorFinal.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void remover_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            lista.RemoveAt(index);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = lista;
        }
    }
}