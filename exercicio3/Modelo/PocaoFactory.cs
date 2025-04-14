using RPGFactoryMethod.Model;
namespace RPGFactoryMethod.Modelo
{
    public class PocaoFactory : ItemFactory
    {
        public override Item CriarItem() => new Pocao();
    }
}