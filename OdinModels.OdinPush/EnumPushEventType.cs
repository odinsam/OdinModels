using System.ComponentModel;

namespace OdinModels.OdinPush
{
    /// <summary>
    /// 推送事件类型
    /// </summary>
    public enum EnumPushEventType
    {
        /// <summary>
        /// 连接
        /// </summary>
        [Description("连接")]SignalRConnected,
        /// <summary>
        /// 断开连接
        /// </summary>
        [Description("断开连接")]SignalRDisConnected,
        /// <summary>
        /// 服务器发送
        /// </summary>
        [Description("服务器发送")]SignalRServerSend,
        /// <summary>
        /// 客户端调用
        /// </summary>
        [Description("客户端调用")]SignalRClientInvoke
        
        
    }
}