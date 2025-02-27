namespace LaptopCustomization
{
    public class Laptop
    {
        private string CPU { get; set; }
        private string RAM { get; set; }
        private string Storage { get; set; }
        private string GPU { get; set; }

        public override string ToString()
        {
            return $"Laptop Configuration:\nCPU: {CPU}\nRAM: {RAM}\nStorage: {Storage}\nGPU: {GPU}";
        }

        // Nested Builder Class
        public class Builder
        {
            private Laptop _laptop { get; set; }

            public Builder() => _laptop = new Laptop();

            public void Reset() => _laptop = new Laptop();

            public Builder ChooseCPU(string cpu)
            {
                _laptop.CPU = cpu;
                return this;
            }

            public Builder ChooseRAM(string ram)
            {
                _laptop.RAM = ram;
                return this;
            }

            public Builder ChooseStorage(string storage)
            {
                _laptop.Storage = storage;
                return this;
            }

            public Builder ChooseGPU(string gpu)
            {
                _laptop.GPU = gpu;
                return this;
            }

            public Laptop GetLaptop()
            {
                var lap = _laptop;
                Reset();
                return lap;
            }
        }
    }
}
