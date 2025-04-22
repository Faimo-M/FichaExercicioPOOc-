using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaExercicioPOO
{
    class Gerente : Funcionario, Beneficio
    {
        public string sector;
        public Gerente(string nome, string bi, double salario, string sector) : base(nome, bi, salario)

        {
            sector = sector;
        }
        public override double CalcularBonus()
        {
            return salario * 0.2;

        }
        public string FornecerPlanoDeSaude()
        {
            return "plano de saude premium";

        }

    }
}
