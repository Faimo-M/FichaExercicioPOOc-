using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaExercicioPOO
{
    public class Program
    {
        static void Main()
        {
            Gerente gerente = new Gerente("carlos silva", "123456", 500, "ti");
            Analista analista = new Analista("Ana paulo", "121212", 300, "desenvolvimeno");
            Console.WriteLine("info do gerente");
            Console.WriteLine($"nome: {gerente.nome}, BI: {gerente.bi}, Salario: {gerente.salario}");
            Console.WriteLine($"bonus: {gerente.CalcularBonus()} ");
            Console.WriteLine($"plano de saude: {gerente.FornecerPlanoDeSaude()}");


        }
    }
}



