using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaExercicioPOO
{
    abstract class Funcionario
    {
        public string nome;
        public string bi;
        public double salario;

        public Funcionario(string nome, string bi, double salario)
        {
            this.nome = nome;
            this.bi = bi;
            this.salario = salario;
        }

        public abstract double CalcularBonus();
    }
}
