namespace OdinModels.Core.Entities
{
    public interface IEntity
    {
        
    }
    public interface IEntityBase<T> : IEntity
    {
        /// <summary>
        /// 默认主键字段是F_Id
        /// </summary>
        T Id { get; set; }
    }
}