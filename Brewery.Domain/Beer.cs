using System;

namespace Brewery.Domain
{
    public class Beer
    {
        #region Properties
        public int BeerId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double? AlcoholByVolume { get; private set; }
        public decimal Price { get; private set; }
        #endregion

        #region Getters
        public bool AlcoholKnown => AlcoholByVolume.HasValue;
        #endregion

        #region Constructors
        /// <summary>
        /// EF Core Constructor
        /// </summary>
        private Beer() { }
        public Beer(string name, string description, decimal price, double? alcoholByVolume )
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Cannot be Null or Empty", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Cannot be Null or Empty", nameof(description));

            if(price < decimal.Zero)
                throw new ArgumentException("Cannot be negative", nameof(description));

            Name = name;
            Description = description;
            Price = price;
            AlcoholByVolume = alcoholByVolume;
        }
        #endregion
    }
}