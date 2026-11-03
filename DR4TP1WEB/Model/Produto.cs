namespace DR4TP1WEB.Model;

public class Produto
{
    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string Nome { get; set; }
    public decimal Preco { get; set; }
}