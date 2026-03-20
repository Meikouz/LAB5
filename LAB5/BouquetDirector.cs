namespace LAB5
{
    public class BouquetDirector
    {
        public Bouquet CreateBouquet(
            IBouquetBuilder builder,
            string name,
            string wrap,
            string ribbon,
            int roses,
            int tulips,
            int daisies)
        {
            builder.Reset();
            builder.SetName(name);
            builder.SetWrap(wrap);
            builder.SetRibbon(ribbon);
            builder.AddRoses(roses);
            builder.AddTulips(tulips);
            builder.AddDaisies(daisies);

            return builder.GetResult();
        }
    }
}