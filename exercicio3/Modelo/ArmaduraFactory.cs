namespace RPGFactoryMethod.Model
{
    public class ArmaduraFactory : ItemFactory
    {
        public override Item CriarItem() => new Armadura();
    }
}