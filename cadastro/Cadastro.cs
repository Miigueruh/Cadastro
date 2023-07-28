public class Cadastro
{

    public double precoAquisicao { get; set; }
    public double porcentagemVenda { get; set; }
    public double valorVenda { get; set; }

    public double Cadastrar(double precoAquisicao, double porcentagemVenda, double valorVenda)
    {
        
        porcentagemVenda = precoAquisicao / 100;
        valorVenda = precoAquisicao + (porcentagemVenda * 5);
        return valorVenda;
    }
}