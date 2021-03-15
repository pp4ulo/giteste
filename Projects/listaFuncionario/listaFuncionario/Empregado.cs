using System.Globalization;

namespace listaFuncionario
{
    class Empregado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado ( int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (Salario * porcentagem / 100); 
        }


        public override string ToString()
        {
            return (ID + ", " + Nome + ", " + Salario.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
