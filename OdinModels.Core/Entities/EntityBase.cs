using System;
using SqlSugar;

namespace OdinModels.Core.Entities
{
    public class EntityBase : AbsEntityBase<long> //默认字段类型是long
    {
        /// <summary>
        /// Id主键
        /// </summary>
        [SugarColumn(ColumnName = "Id",IsPrimaryKey = true,IsIdentity = false)]
        public virtual long Id { get; set; }
        
        /// <summary>
        /// Remark
        /// </summary>
        [SugarColumn(ColumnName = "Remark",Length = 128)]
        public virtual string Remark { get; set; }

        /// <summary>
        /// CreateUser default: odin
        /// </summary>
        [SugarColumn(ColumnName = "CreateUser", Length = 32)]
        public virtual string CreateUser { get; set; } = "odin";
        
        /// <summary>
        /// CreateTime
        /// </summary>
        [SugarColumn(ColumnName = "CreateTime")]
        public virtual DateTime CreateTime { get; set; }
        
        /// <summary>
        /// Remark
        /// </summary>
        [SugarColumn(ColumnName = "UpdateUser", Length = 32)]
        public virtual string UpdateUser { get; set; } = "odin";
        
        /// <summary>
        /// Remark
        /// </summary>
        [SugarColumn(ColumnName = "UpdateTime")]
        public virtual string UpdateTime { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [SugarColumn(ColumnName = "IsDelete")]
        public virtual int IsDelete { get; set; } = 0;
    }
}