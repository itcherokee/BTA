namespace BTA.Core.Domain.Base
{
    public abstract class BaseModel<TKey>
    {
        public TKey Id { get; set; }
    }
}