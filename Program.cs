using Lanchonete.Models;

// Criando uma um Cardápio de Lanches:
List<Lanche> cardapio = new List<Lanche>();

Lanche l1 = new Lanche(1, "Cachoro Quente", 4.00M);
Lanche l2 = new Lanche(2, "X-Salada", 4.50M);
Lanche l3 = new Lanche(3, "X-Bacon", 5.00M);
Lanche l4 = new Lanche(4, "Torrada simples", 2.00M);
Lanche l5 = new Lanche(5, "Refrigerante", 1.50M);

cardapio.Add(l1);
cardapio.Add(l2);
cardapio.Add(l3);
cardapio.Add(l4);
cardapio.Add(l5);
// Fim do Cardápio.


// Exibindo o Cardápio na tela:
Console.WriteLine("||==================================||");
Console.WriteLine("||       BEM VINDO AO LANCHE'S      ||");
Console.WriteLine("||==================================||");
Console.WriteLine("|| CARDÁPIO: Código, lanche e valor ||");
Console.WriteLine("||----------------------------------||");

foreach (var item in cardapio)
{
    Console.WriteLine($"||[ {item.Codigo} ] - {item.Especificacao} = {item.Preco}");
}

Console.WriteLine("||__________________________________||");



// Recebendo duas entradas referente ao código do lanche pedido e a quantidade desejada:
Console.WriteLine("Digite o código do lanche desejado e a quantidade:");
string[] entrada = Console.ReadLine().Split(' ');

int codigo = int.Parse(entrada[0]);
int quantidade = int.Parse(entrada[1]);

// Busca o lanche no cardápio pelo código
    Lanche lancheSelecionado = cardapio.FirstOrDefault(l => l.Codigo == codigo);

// Verifica se o lanche foi encontrado, se sim, exibi o total a pagar:
    if (lancheSelecionado != null)
    {
        decimal total = lancheSelecionado.Preco * quantidade;
        Console.WriteLine($"Total: {total:C2}");
    }
    else
    {
        Console.WriteLine("Lanche não encontrado no cardápio.");
    }
