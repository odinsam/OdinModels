using SqlSugar;

namespace OdinModels.OdinSignalR.Entities
{
    /// <summary>
    /// signalR 推送记录表
    /// </summary>
    [SugarTable("tb_PushEvent")]
    public class PushEventEntity
    {
        /// <summary>
        /// 事件名称
        /// </summary>
        [SugarColumn(ColumnName = "EventName",Length = 255)]
        public string EventName { get; set; }
        
        /// <summary>
        /// 事件详情
        /// </summary>
        [SugarColumn(ColumnName = "EventInfo",Length = 2048)]
        public string EventInfo { get; set; }
        
        /// <summary>
        /// 事件流向
        /// </summary>
        [SugarColumn(ColumnName = "Direction",Length = 16)]
        public string Direction { get; set; }
        
        /// <summary>
        /// 事件参数
        /// </summary>
        [SugarColumn(ColumnName = "EventParams",Length = 2048)]
        public string EventParams { get; set; }
    }
}