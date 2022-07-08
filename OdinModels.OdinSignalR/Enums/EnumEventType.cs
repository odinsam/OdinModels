using System.ComponentModel;

namespace OdinModels.OdinSignalR.Enums
{
    public enum EnumEventType
    {
        [Description("Signalr-Connected")] SignalrConnected,
        [Description("Signalr-DisConnected")] SignalrDisConnected,
        [Description("Signalr-SendMessage")] SignalrSendMessage,
        [Description("Signalr-ClientInvoke")] SignalrClientInvoke,
    }
}
