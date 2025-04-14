using System;

namespace RPGFactoryMethod.Model
{
    public class Armadura : Item
    {
        public void Usar()
        {
            Console.WriteLine("Você vestiu uma armadura resistente! +15 de defesa.");
        }
    }
}