namespace BTA.Core.Domain.Orgaization
{
    using BTA.Core.Domain.Base;

    public class Department : BaseModel<int>
    {
        public string Name { get; set; }
    }
}