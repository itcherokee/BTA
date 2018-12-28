namespace BTA.Core.Domain.Orgaization
{
    using BTA.Core.Domain.Base;

    public class Town : BaseModel<int>
    {
        public string Name { get; set; }

        public string Zip { get; set; }
    }
}