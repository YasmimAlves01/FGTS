double salario;
double porcentagem;

Console.WriteLine("Bem-vindo ao cauculo do FGTS");
Console.WriteLine("Por favor digite seu salario para podermos calcular");
Console.Write("Salario (R$)...:");

salario = Convert.ToDouble(Console.ReadLine());

porcentagem = salario * 0.08;

Console.WriteLine($"O seu salario é: R$ {salario}, e o valor do seu FGTS é: R$ {porcentagem}");