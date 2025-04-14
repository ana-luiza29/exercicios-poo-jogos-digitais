using System;

namespace RPGFactoryMethod.Model
{
    public class Arma : Item
    {
        public void Usar()
        {
            Console.WriteLine("Você equipou uma espada poderosa! +10 de ataque.");
        }
    }
}