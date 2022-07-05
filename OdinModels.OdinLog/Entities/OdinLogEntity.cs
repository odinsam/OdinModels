using OdinModels.Core.Entities;
using SqlSugar;

namespace OdinModels.OdinLog.Entities
{
    /// <summary>
    /// log日志
    /// </summary>
    public class OdinLogEntity : AbsEntityBase<string>
    {
        /// <summary>
        /// Id主键
        /// </summary>
        [SugarColumn(ColumnName = "Id",IsPrimaryKey = true)]
        public new string Id { get; set; }
        
        /// <summary>
        /// 日志等级
        /// </summary>
        [SugarColumn(ColumnName = "LogLevel",Length = 64)]
        public string LogLevel { get; set; }
        
        /// <summary>
        /// 日志内容
        /// </summary>
        [SugarColumn(ColumnName = "LogContent",Length = 1024)]
        public string LogContent { get; set; }
        
        /// <summary>
        /// 异常详情
        /// </summary>
        [SugarColumn(ColumnName = "ExceptionInfo")]
        public string ExceptionInfo { get; set; }
    }
}