using LAB5;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB5
{
    public class Bouquet
    {
        public string Name { get; set; }
        public string Wrap { get; set; }
        public string RibbonColor { get; set; }
        public List<Flower> Flowers { get; set; }

        public Bouquet()
        {
            Flowers = new List<Flower>();
            Name = "Без назви";
            Wrap = "Без упаковки";
            RibbonColor = "Без стрічки";
        }

        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }

        public decimal GetTotalPrice()
        {
            return Flowers.Sum(f => f.Price);
        }

        public Bouquet Clone()
        {
            Bouquet copy = new Bouquet
            {
                Name = this.Name,
                Wrap = this.Wrap,
                RibbonColor = this.RibbonColor,
                Flowers = new List<Flower>()
            };

            foreach (Flower flower in Flowers)
            {
                copy.Flowers.Add(flower.Clone());
            }

            return copy;
        }

        public string GetDetails()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Назва: {Name}");
            sb.AppendLine($"Упаковка: {Wrap}");
            sb.AppendLine($"Стрічка: {RibbonColor}");
            sb.AppendLine($"Кількість квітів: {Flowers.Count}");
            sb.AppendLine($"Загальна вартість: {GetTotalPrice()} грн");
            sb.AppendLine();
            sb.AppendLine("Склад букета:");

            if (Flowers.Count == 0)
            {
                sb.AppendLine("Немає квітів");
            }
            else
            {
                var groups = Flowers
                    .GroupBy(f => f.Type)
                    .Select(g => $"{g.Key}: {g.Count()} шт.");

                foreach (var group in groups)
                {
                    sb.AppendLine("- " + group);
                }
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{Name} | {Flowers.Count} квіток | {GetTotalPrice()} грн";
        }
    }
}