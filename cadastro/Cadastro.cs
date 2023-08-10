public class Cadastro
{
    public string Id { get; set; }
    public string Descricao { get; set; }
    public double PrecoAquisicao { get; set; }
    public double Lucro { get; set; }
    public double PrecoVenda { get; set; }

    public Cadastro() 
    { 
        
    }

    public Cadastro(string id, string descricao, double PrecoAquisicao, double lucro, double PrecoVenda)
    {
        this.Id = id;
        this.Descricao = descricao;
        this.PrecoVenda = PrecoVenda;
        this.PrecoAquisicao = PrecoAquisicao;
        this.Lucro = lucro;
    }
    

}