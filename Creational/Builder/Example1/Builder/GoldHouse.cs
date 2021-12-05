namespace Builder.Example1.Builder
{
    public class GoldHouse
    {
        private readonly House house = new();

        public void BuildGoldSystems()
        {
            house.Add("Building Golden Systems...");
        }

        public void BuildExpensiveInfrastructure()
        {
            house.Add("Building Gold Infrastructure...");
        }

        public void BuildGoldFoundation()
        {
            house.Add("Building Gold Foundation ...");
        }

        public House GetFinalOutcome()
        {
            return house;
        }
    }
}
