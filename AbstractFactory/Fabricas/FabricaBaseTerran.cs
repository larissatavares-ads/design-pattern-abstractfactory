using AbstractFactory.Energias;
using AbstractFactory.Interface;
using AbstractFactory.Revestimentos;

namespace AbstractFactory.Fabricas
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Terran criada com sucesso!");

            var revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();

            var energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
