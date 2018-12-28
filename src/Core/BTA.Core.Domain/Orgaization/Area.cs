namespace BTA.Core.Domain.Orgaization
{
    using System.Collections.Generic;

    using BTA.Core.Domain.Base;

    public class Area : BaseModel<int>
    {
        public string Name { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}