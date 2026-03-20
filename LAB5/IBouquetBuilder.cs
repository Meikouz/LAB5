using LAB5;

namespace LAB5
{
    public interface IBouquetBuilder
    {
        void Reset();
        void SetName(string name);
        void SetWrap(string wrap);
        void SetRibbon(string ribbonColor);
        void AddRoses(int count);
        void AddTulips(int count);
        void AddDaisies(int count);
        Bouquet GetResult();
    }
}