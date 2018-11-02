using System;
using System.Collections.Generic;

namespace Brewery.Domain
{
    public class Brewer
    {
        #region Properties
        public int BrewerId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime? DateEstablished { get; private set; }
        #endregion

        #region Collections
        public ICollection<Beer> Beers { get; private set; } = new HashSet<Beer>();
        #endregion

        #region Getters
        public int NrOfBeers => Beers.Count;
        #endregion

        #region Constructors
        /// <summary>
        /// EF Core Constructor
        /// </summary>
        private Brewer()
        {

        }
        public Brewer(string name, string description, DateTime? dateEstablished = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Cannot be Null or Empty", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Cannot be Null or Empty", nameof(description));

            Name = name;
            Description = description;
            DateEstablished = dateEstablished;
        }
        #endregion
    }
}
