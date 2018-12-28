namespace BTA.Core.Domain.Orgaization
{
    using BTA.Core.Domain.Base;

    public class Company : BaseModel<int>
    {
        public string Name { get; set; }

        public Employee Manager { get; set; }

        public Address Address { get; set; }
    }
}