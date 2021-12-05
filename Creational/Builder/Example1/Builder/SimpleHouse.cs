namespace Builder.Example1.Builder
{
    public class SimpleHouse : IHouseBuilder
    {
        private readonly House house = new();

        /// <summary>
        /// Builds a basic additional systems.
        /// </summary>
        public void BuildAdditionalSystems()
        {
            house.Add("Building Basic Additional Systems...");
        }

        /// <summary>
        /// Builds basic Infrastructure.
        /// </summary>
        public void BuildBasicInfrastructure()
        {
            house.Add("Building Basic Infrastructure...");
        }

        /// <summary>
        /// Builds basic foundation.
        /// </summary>
        public void BuildFoundation()
        {
            house.Add("Building Foundation ...");
        }

        /// <summary>
        /// Builds a simple house as final output.
        /// </summary>
        /// <returns></returns>
        public House GetFinalOutcome()
        {
            return house;
        }
    }
}