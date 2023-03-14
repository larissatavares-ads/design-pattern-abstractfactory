using AbstractFactory.Interface;

namespace AbstractFactory.Energias
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base comcristais");
        }
    }
}
