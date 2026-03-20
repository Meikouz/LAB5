namespace LAB5
{
    public class BouquetBuilder : IBouquetBuilder
    {
        private Bouquet bouquet;

        public BouquetBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            bouquet = new Bouquet();
        }

        public void SetName(string name)
        {
            bouquet.Name = string.IsNullOrWhiteSpace(name) ? "Без назви" : name;
        }

        public void SetWrap(string wrap)
        {
            bouquet.Wrap = wrap;
        }

        public void SetRibbon(string ribbonColor)
        {
            bouquet.RibbonColor = ribbonColor;
        }

        public void AddRoses(int count)
        {
            for (int i = 0; i < count; i++)
            {
                bouquet.AddFlower(new Flower("Троянда", "Червона", 80));
            }
        }

        public void AddTulips(int count)
        {
            for (int i = 0; i < count; i++)
            {
                bouquet.AddFlower(new Flower("Тюльпан", "Жовтий", 55));
            }
        }

        public void AddDaisies(int count)
        {
            for (int i = 0; i < count; i++)
            {
                bouquet.AddFlower(new Flower("Ромашка", "Біла", 35));
            }
        }

        public Bouquet GetResult()
        {
            Bouquet result = bouquet;
            Reset();
            return result;
        }
    }
}