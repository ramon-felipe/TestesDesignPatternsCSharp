
namespace TesteDesignPatterns_Chain_of_Responsibility.Descontos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentos();
            IDesconto d3 = new SemDesconto();

            d1.ProximoDesconto = d2;
            d2.ProximoDesconto = d3;

            return d1.Desconta(orcamento);
        }
    }
}
