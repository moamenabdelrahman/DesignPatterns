namespace LaptopCustomization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new Laptop.Builder();

            var laptop = builder.ChooseCPU("Intel i5")
                                .ChooseRAM("16GB")
                                .ChooseStorage("1TB SSD")
                                .ChooseGPU("NVIDIA RTX 3060")
                                .GetLaptop();

            Console.WriteLine(laptop);

            Console.WriteLine("\n**************************************************\n");

            var laptop2 = builder.ChooseCPU("AMD Ryzen 7")
                                .ChooseRAM("16GB")
                                .ChooseStorage("1TB SSD")
                                .ChooseGPU("NVIDIA GTX 1650")
                                .GetLaptop();
            Console.WriteLine(laptop2);
        }
    }
}
