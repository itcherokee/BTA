namespace BTA.Core.Domain.Orgaization
{
    using System.Collections.Generic;

    using BTA.Core.Domain.Base;

    public class Zone : BaseModel<int>
    {
        public string Name { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}