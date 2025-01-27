// Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0. O programa deve contar quantos votos cada candidato recebeu, implementando a solução com while, do while e for.

// utilizando while
int votosA = 0, votosB = 0;
int voto;
Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B e 0 para sair):");
while (true)
{
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0) break;
    if (voto == 1) votosA++;
    else if (voto ==2) votosB++;
}
Console.WriteLine($"Candidato A: {votosA} votos, Candidato B {votosB} votos");

// utilizando do while
votosA = 0;
votosB = 0;
do
{
    Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B e 0 para sair):");
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;
} while (voto != 0);
Console.WriteLine($"Candidato A: {votosA} votos, Candidato B {votosB} votos");

// utilizando for
votosA = 0;
votosB = 0;
for (; ; )
{
    Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B e 0 para sair):");
    voto = Convert.ToInt32(Console.ReadLine());
    if (voto == 0) break;
    if (voto == 1) votosA++;
    else if (voto == 2) votosB++;
}
Console.WriteLine($"Candidato A: {votosA} votos, Candidato B {votosB} votos");