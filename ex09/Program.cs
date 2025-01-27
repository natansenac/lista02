// Um cliente deseja saber o total de suas compras em um supermercado. O aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A soma dos valores das compras deve ser implementado utilizando as três estruturas de repetição.

// utilizando while
double totalCompras = 0;
double valorCompra;
Console.WriteLine("Digite o valor das compras (0 para sair):");
while (true)
{
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0) break;
    totalCompras += valorCompra;
}
Console.WriteLine($"Total de compras: {totalCompras}");

// utilizando do while
totalCompras = 0;
do
{
    Console.WriteLine("Digite o valor das compras (0 para sair):");
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra != 0) totalCompras += valorCompra;
} while (valorCompra != 0);
Console.WriteLine($"Total de compras: {totalCompras}");

// utilizando for
totalCompras = 0;
for (; ; )
{
    Console.WriteLine("Digite o valor das compras (0 para sair):");
    valorCompra = Convert.ToDouble(Console.ReadLine());
    if (valorCompra == 0) break;
    totalCompras += valorCompra;
}
Console.WriteLine($"Total de compras: {totalCompras}");
