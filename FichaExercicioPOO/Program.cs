using System;
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

interface Beneficio
{
    string FornecerPlanoDeSaude();
}
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
class Analista : Funcionario, Beneficio
{
    private string especialidade;
    public Analista(string nome, string bi, double salario, string especialidade) : base(nome, bi, salario)
    {
        especialidade = especialidade;
    }
    public override double CalcularBonus() {
        return salario * 0.1;
    }
    public string FornecerPlanoDeSaude() {
        return "plano de saude basico";
    }
}

public class Empresa
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



