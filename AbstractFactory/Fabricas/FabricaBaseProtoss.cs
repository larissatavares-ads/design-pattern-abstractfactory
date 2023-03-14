using AbstractFactory.Energias;
using AbstractFactory.Interface;
using AbstractFactory.Revestimentos;

namespace AbstractFactory.Fabricas
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso!")
;
            var revestimento = new RevestimentoBaseProtoss();
            revestimento.Composicao();

            var energia = new EnergiaBaseProtoss()            ;
            energia.Composicao();
        }
    }
}
