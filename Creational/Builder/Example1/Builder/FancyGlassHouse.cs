namespace Builder.Example1.Builder
{
    public class FancyGlassHouse : IHouseBuilder
    {
        private readonly House house = new();

        /// <summary>
        /// Building additional systems.
        /// </summary>
        public void BuildAdditionalSystems()
        {
            house.Add("Building Additional Systems... such as heating, extra insulation, ventilation etc...");
        }

        /// <summary>
        /// Building the basic infrastructure such as walls, windows, in addition to the fancy items such as fancy floor mats, fancy window curtains etc.
        /// </summary>
        public void BuildBasicInfrastructure()
        {
            house.Add("Building Fancy Infrastructure...");
        }

        /// <summary>
        /// Building fancy foundation.
        /// </summary>
        public void BuildFoundation()
        {
            house.Add("Building Fancy Foundation ...");
        }

        /// <summary>
        /// Returns a House which is fancy.
        /// </summary>
        /// <returns> Fancy House.</returns>
        public House GetFinalOutcome()
        {
            return house;
        }
    }
}
