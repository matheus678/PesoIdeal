using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: PesoIdeal] Solicite que o usuário digite sua altura e o seu sexo ('M' para masculino, 'F' para feminino). Calcule e exiba seu peso ideal.
            Para homens, altura x 72.7 - 58.0
            Para mulheres, altura x 62.1 - 44.7
            Ex.:
            Digite sua altura em m..........: 1,73
            Sexo [M]asculino / [F]eminino...: M
            Seu peso ideal é 67,7kg.
            ou
            Digite sua altura em m..........: 1,73
            Sexo [M]asculino / [F]eminino...: F
            Seu peso ideal é 62,7kg.
            */
 
            bool M;
            bool F;
            double AlturaUsuario;
            double ResultadoIMCfeminino;
            double ResualtadoIMCmasculino;
           

            Console.WriteLine("Olá usuário, irei ajuda-lo fornecendo seu peso ideal");

            Console.Write("Digite sua altura atual em (M)...:");
            AlturaUsuario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sexo [M]asculino / [F]eminino...:");

            F = Console.ReadLine().ToUpper() == "F";
            M = Console.ReadLine().ToUpper() == "M";

            // Utilizei esse comando para o ptogrma identificar o sexo 

            ResultadoIMCfeminino = AlturaUsuario* 62.1 - 44.7;

            ResualtadoIMCmasculino = AlturaUsuario * 72.7 - 58;

            if (F)

                Console.WriteLine($"Seu peso ideal é {ResultadoIMCfeminino} kg.");

            else
            
                Console.WriteLine($"Seu peso ideal é {ResualtadoIMCmasculino} kg.");                                 
        }
    }
}
