Double media = 0;
Double idade1 = 0;
Double idade2 = 0;
Double idade3= 0;
Double idade4 = 0;
Double idade5 = 0;

Console.WriteLine("Programa que calcula a idade media de cinco alunos");

Console.WriteLine("informe a idade do 1º Aluno : ");
idade1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a idade do 2º Aluno : ");
idade2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a idade do 3º Aluno : ");
idade3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a idade do 4º Aluno : ");
idade4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a idade do 5º Aluno : ");
idade5 = Convert.ToDouble(Console.ReadLine());

media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
Console.WriteLine("A ídade média dos Alunos é " + media);
Console.ReadKey();