using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace OdinModels.OdinUtils.Utils.OdinNet
{
    public class NetworkHelper
    {
        public static IList<string> GetHostIpForFas()
        {
            try
            {
                IList<string> strIp = new List<string>();
                //NetworkInterface：提供网络接口的配置和统计信息。
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                    UnicastIPAddressInformationCollection allAddress = adapterProperties.UnicastAddresses;
                    //这里是根据网络适配器名称找到对应的网络，adapter.Name即网络适配器的名称
                    if (allAddress.Count > 0 && adapter.Name == "WLAN 2")
                    {
                        foreach (UnicastIPAddressInformation addr in allAddress)
                        {
                            if (addr.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                strIp.Add(addr.Address.ToString());
                            }
                        }
                    }
                }
                return strIp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}