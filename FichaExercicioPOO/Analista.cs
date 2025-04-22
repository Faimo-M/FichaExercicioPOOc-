using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaExercicioPOO
{
    class Analista : Funcionario, Beneficio
    {
        private string especialidade;
        public Analista(string nome, string bi, double salario, string especialidade) : base(nome, bi, salario)
        {
            especialidade = especialidade;
        }
        public override double CalcularBonus()
        {
            return salario * 0.1;
        }
        public string FornecerPlanoDeSaude()
        {
            return "plano de saude basico";
        }
    }
}
