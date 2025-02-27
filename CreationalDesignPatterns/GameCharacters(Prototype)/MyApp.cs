using GameCharacters.Characters;

namespace GameCharacters
{
    public class MyApp
    {
        public void SomeOperation()
        {
            var char1 = new Character();

            Console.WriteLine("Before");
            Console.WriteLine("Character 1:");
            char1.Display();

            Console.WriteLine("\n******************************\n");
            Console.WriteLine("After Modifying Character 1");

            var char2 = char1.Clone();
            char1.SetClass(ClassType.Mage)
                 .SetArmor(ArmorType.Heavy);

            Console.WriteLine("Character 1:");
            char1.Display();

            Console.WriteLine("Character 2:");
            char2.Display();
        }
    }
}
