Console.WriteLine("Digite seu salario por hora..: ");
    double salario = Convert.ToDouble(Console.ReadLine());   //salario por hora
    
Console.WriteLine("Digite a quantidade de horas trabalhadas..: ");
   int hora = Convert.ToInt32(Console.ReadLine());          //hora
   
Console.WriteLine("Digite a quantidade de horas extras trabalhadas..: ");
    int horaEXtra = Convert.ToInt32(Console.ReadLine());     //hora extra
    double salarioFinal = calculoSalario();
Console.WriteLine($"Seu salario é {salarioFinal:C2}");

    //Função para fazer o salario
        double calculoSalario()
        {
            double salarioExtra = salario * 0.4;
            salarioExtra *= horaEXtra;
            double salarioFinal = salario * hora;
            double salarioTotal = salarioFinal+salarioExtra;
            return salarioTotal;
        }
    

