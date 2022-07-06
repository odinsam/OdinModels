using OdinModels.Core.Entities;
using SqlSugar;

namespace OdinModels.OdinSignalR.Entities
{
    /// <summary>
    /// signalR 推送记录表
    /// </summary>
    [SugarTable("tb_PushRecord_SignalR")]
    public class PushRecordSignalREntity:EntityBase<long>
    {
        /// <summary>
        /// 推送人
        /// </summary>
        [SugarColumn(ColumnName = "FromUser",Length = 32)]
        public string FromUser { get; set; }
        
        /// <summary>
        /// 消息接受组
        /// </summary>
        [SugarColumn(ColumnName = "ToGroup")]
        public string ToGroup { get; set; }
        
        /// <summary>
        /// 消息接收人
        /// </summary>
        [SugarColumn(ColumnName = "ToUser",Length = 32)]
        public string ToUser { get; set; }
        
        /// <summary>
        /// 消息内容
        /// </summary>
        [SugarColumn(ColumnName = "PushContent")]
        public string PushContent { get; set; }
        
        /// <summary>
        /// 消息事件编号
        /// </summary>
        [SugarColumn(ColumnName = "EventId")]
        public int EventId { get; set; }
    }
}