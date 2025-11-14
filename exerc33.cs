using System;
   class Program{
     static void Main(string [] args)
     {
       double mediah = 0;
        double mediaidade = 0;
        int alunos = 45;
        Console.Write("Digite a sua altura:");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua idade:");
        int idade = Convert.ToInt(Console.ReadLine());
        
        
        if(h < 1.70){
           mediah += h / alunos;
         
        }

        if(idade > 20){
           mediaidade += idade/ alunos;
         
        }
        
       }
       Console.WriteLine("Media das alturas abaixode 1,70;" + mediah);
       Console.WriteLine("Media das idades acima de 20;" + mediaidade);
      
     }
     }
