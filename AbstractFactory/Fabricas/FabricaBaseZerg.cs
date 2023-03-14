using AbstractFactory.Energias;
using AbstractFactory.Interface;
using AbstractFactory.Revestimentos;

namespace AbstractFactory.Fabricas
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso!");

            var revestimento = new RevestimentoBaseZerg();
            revestimento.Composicao();

            var energia = new EnergiaBaseZerg();
            energia.Composicao();
        }
    }
}
