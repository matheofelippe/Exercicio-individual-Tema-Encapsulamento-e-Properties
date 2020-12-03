using System;
using System.Globalization;

public class Produto
{
    private string _nome; //variavel do nome do produto
    private double _preco; //variavel do preço do produto
    private int _quantidade; //variavel da quantidade de produtos

    public Produto(string nome, double preco, int quantidade) //Construtor personalizado
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string Nome //Utilização do Properties
    {
        get { return _nome; }
        set { if(value!=null && value.Length > 1)
            {
                _nome = value;
            } 
        }
    }

    public double Preco //Utilização do Properties para preço
    {
        get { return _preco; }
    }

    public int Quantidade //Utilização do Properties para quantidade
    {
        get { return _quantidade; }
    }

    public double ValorTotalEmEstoque() //metodo que mostra o valor total em reais do estoque
    {
        return _preco * _quantidade;
    }

    public void AdcionarProdutos(int quantidade) //metodo que adciona produtos no estoque
    {
        _quantidade = _quantidade + quantidade;
    }

    public void RemoverProdutos(int quantidade) //metodo que remove produtos do estoque
    {
        _quantidade = _quantidade - quantidade;
    }

    public override string ToString() //metodo que mostra todos os dados do produtos
    {
        return _nome
        + ", R$"
        + _preco.ToString("F2", CultureInfo.InvariantCulture) //mostra apenas 2(F2) numeros depois da virgula
        + ", "
        + _quantidade
        + " unidades, Total: R$"
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); //mostra apenas 2(F2) numeros depois da virgula
    }
}
