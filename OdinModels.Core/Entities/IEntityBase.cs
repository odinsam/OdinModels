namespace OdinModels.Core.Entities
{
    public interface IEntityBase<TId>
    {
        /// <summary>
        /// 默认主键字段是F_Id
        /// </summary>
        TId Id { get; set; }
    }
}