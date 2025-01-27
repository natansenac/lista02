// Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A solução deve ser implementada usando while, do while e for.

// utilizando while
double somaIdades = 0;
int contador = 0;
int idade;
Console.WriteLine("Digite as idades (0 para sair):");
while (true)
{
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade == 0) break;
    somaIdades += idade;
    contador++;
}
double mediaIdade = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($"Média das idades: {mediaIdade}");

// utilizando do while
somaIdades = 0;
contador = 0;
do
{
    Console.WriteLine("Digite as idades (0 para sair):");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade != 0)
    {
        somaIdades += idade;
        contador++;
    }
} while (idade != 0);
mediaIdade = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($"Média das idades: {mediaIdade}");

// utilizando for
somaIdades = 0;
contador = 0;
for (; ; )
{
    Console.WriteLine("Digite as idades (0 para sair):");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade == 0) break;
    somaIdades += idade;
    contador++;
}
mediaIdade = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($"Média das idades: {mediaIdade}");

  
