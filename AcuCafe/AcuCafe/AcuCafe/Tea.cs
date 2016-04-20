namespace AcuCafe
{
    public class HotTea : Drink
    {
        public override string Description
        {
            get { return "Hot tea"; }
        }

        public override double Cost()
        {
            double cost = 1;

            if (HasMilk)
            {
                cost += MilkCost;
            }

            if (HasSugar)
            {
                cost += SugarCost;
            }

            return cost;
        }
    }
}
