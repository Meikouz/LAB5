namespace LAB5
{
    public class Flower
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public Flower(string type, string color, decimal price)
        {
            Type = type;
            Color = color;
            Price = price;
        }

        public Flower Clone()
        {
            return new Flower(Type, Color, Price);
        }

        public override string ToString()
        {
            return $"{Type} ({Color}) - {Price} грн";
        }
    }
}