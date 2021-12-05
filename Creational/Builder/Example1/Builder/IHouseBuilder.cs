namespace Builder.Example1.Builder
{
    /// <summary>
    /// A basic builder having all required step to build a house.
    /// </summary>
    public interface IHouseBuilder
    {
        /// <summary>
        /// Building foundation.
        /// </summary>
        /// <returns>string.</returns>
        public void BuildFoundation();

        /// <summary>
        /// Building Basic Infrastructure required for house.
        /// </summary>
        /// <returns>string.</returns>
        public void BuildBasicInfrastructure();

        /// <summary>
        /// Building Additional systems, i.e heating, cooling, ventilation etc.
        /// </summary>
        /// <returns>string.</returns>
        public void BuildAdditionalSystems();

        /// <summary>
        /// This return the final House Object which is created.
        /// </summary>
        /// <returns></returns>
        public House GetFinalOutcome();
    }
}