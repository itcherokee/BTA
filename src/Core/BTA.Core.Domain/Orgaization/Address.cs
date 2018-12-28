namespace BTA.Core.Domain.Orgaization
{
    using BTA.Core.Domain.Base;

    public class Address : BaseModel<int>
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public Town Town { get; set; }

        public string District { get; set; }
    }
}