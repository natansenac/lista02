// Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0. Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição.

// utilizando while
int totalEstoque = 0;
int recebidos, vendidos;
Console.WriteLine("Digte a quantidade de produtos recebidos e vendidos (0 para sair)");
while (true)
{
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("Vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
}
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");

// utilizando do while
totalEstoque = 0;
do
{
    Console.WriteLine("Digte a quantidade de produtos recebidos e vendidos (0 para sair):");
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("Vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
} while (true);
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");

// utilizando for
totalEstoque = 0;
for (; ; )
{
    Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos (0 para sair):");
    Console.Write("Recebidos: ");
    recebidos = Convert.ToInt32(Console.ReadLine());
    if (recebidos == 0) break;
    Console.Write("Vendidos: ");
    vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos - vendidos;
}
Console.WriteLine($"Total de produtos em estoque: {totalEstoque}");
