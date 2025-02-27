namespace GameCharacters.Characters
{
    public class Character
    {
        private ClassType Class { get; set; }
        private WeaponType Weapon { get; set; }
        private ArmorType Armor { get; set; }

        public Character()
        {
            Class = ClassType.Warrior;
            Weapon = WeaponType.Sword;
            Armor = ArmorType.Medium;
        }

        public Character(Character character)
        {
            Class = character.Class;
            Weapon = character.Weapon;
            Armor = character.Armor;
        }

        public Character SetClass(ClassType type)
        {
            if (!Enum.IsDefined<ClassType>(type)) throw new ArgumentException();
            Class = type;
            return this;
        }

        public Character SetWeapon(WeaponType type)
        {
            if (!Enum.IsDefined<WeaponType>(type)) throw new ArgumentException();
            Weapon = type;
            return this;
        }

        public Character SetArmor(ArmorType type)
        {
            if (!Enum.IsDefined<ArmorType>(type)) throw new ArgumentException();
            Armor = type;
            return this;
        }

        public Character Clone()
        {
            return new(this);
        }

        public void Display()
        {
            string tmp = $"Character Info:\n\t- Class => {Class}\n\t- Weapon => {Weapon}\n\t- Armor => {Armor}";
            Console.WriteLine(tmp);
        }
    }
}
