namespace RPGFactoryMethod.Model
{
    public class ArmaFactory : ItemFactory
    {
        public override Item CriarItem() => new Arma();
    }
}