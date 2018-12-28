namespace BTA.Core.Domain.Orgaization
{
    using BTA.Core.Domain.Base;

    public class Address : BaseModel<int>
    {
        public string Street { get; set; }

        public string Details { get; set; }

        public string Town { get; set; }

        public string Zip { get; set; }

        public string District { get; set; }

        public string Country { get; set; }
    }
}