namespace OdinModels.Core.Entities
{
    public class AbsEntityBase<TId> : IEntityBase<TId> //默认字段类型是long
    {
        public virtual TId Id { get; set; }
    }
}