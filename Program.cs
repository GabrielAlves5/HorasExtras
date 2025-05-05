double salario;
int hora, horaEXtra;
    Console.WriteLine("Digite seu salario por hora..: ");
       salario = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de horas trabalhadas..: ");
        hora = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de horas extras trabalhadas..: ");
        horaEXtra = Convert.ToInt32(Console.ReadLine());
double salarioExtra = salario *0.40;

    salarioExtra = salarioExtra*horaEXtra;
    salario = salario*hora;
    Console.WriteLine($"Seu salario é {salario+salarioExtra}");


