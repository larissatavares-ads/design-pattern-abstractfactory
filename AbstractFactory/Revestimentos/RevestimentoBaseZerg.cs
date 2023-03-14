using AbstractFactory.Interface;

namespace AbstractFactory.Revestimentos
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha");        }
    }
}
