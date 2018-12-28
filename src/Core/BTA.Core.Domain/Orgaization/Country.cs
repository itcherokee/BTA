namespace BTA.Core.Domain.Orgaization
{
    using System.Collections.Generic;

    using BTA.Core.Domain.Base;

    public class Country : BaseModel<int>
    {
        public string Name { get; set; }

        public ICollection<Area> Areas { get; set; }
    }
}