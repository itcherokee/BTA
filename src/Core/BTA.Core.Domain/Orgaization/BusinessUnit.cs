namespace BTA.Core.Domain.Orgaization
{
    using BTA.Core.Domain.Base;

    public class BusinessUnit : BaseModel<int>
    {
        public string Name { get; set; }

        public Company Company { get; set; }
    }
}