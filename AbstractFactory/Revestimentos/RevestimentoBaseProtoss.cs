using AbstractFactory.Interface;

namespace AbstractFactory.Revestimentos
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}
