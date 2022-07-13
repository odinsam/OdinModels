using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using OdinModels.Constants;
using OdinModels.OdinUtils;
using OdinModels.OdinUtils.OdinExceptionExtensions;
using OdinModels.OdinUtils.OdinExtensions;

namespace OdinModels.Core.ConfigModels;

public class ServerConfig
{
    public UrlConfig[] Urls { get; set; }

    public List<string> GetAllUrls()
    {
        List<string> urls = new List<string>();
        foreach (var url in Urls)
        {
            var u = $"{url.Protocol}://{url.Ip}";
            if (
                (url.Protocol.CompareString(SystemConstant.KEY_OF_HTTP) && !url.Port.CompareString("80"))
                ||
                (url.Protocol.CompareString(SystemConstant.KEY_OF_HTTPS) && !url.Port.CompareString("443")))
                u += $":{url.Port}";
            urls.Add(u);
        }
        return urls;
    }
    /// <summary>
    /// Get Server Uri by Protocol.
    /// if protocol is null that get HttpsUrl. if httpsUrl is null that get httpUrl. if httpUrl is null that throw ex 
    /// </summary>
    /// <param name="protocol"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public UrlConfig GetServiceUrlConfigByProtocol(string protocol=null)
    {
        if (Urls == null)
            throw new OdinException(EnumOdinException.ParamNotNull);
        var uri = protocol.IsNullOrEmpty()
            ?
            (Urls.SingleOrDefault(u => u.Protocol.CompareString(SystemConstant.KEY_OF_HTTPS)) 
             ?? 
             Urls.SingleOrDefault(u => u.Protocol.CompareString(SystemConstant.KEY_OF_HTTP)))
            :
            Urls.SingleOrDefault(u => u.Protocol.CompareString(protocol));
        if (uri == null)
            throw new OdinException(EnumOdinException.ParamNotNull);
        else
            return new UrlConfig()
            {
                Protocol = uri.Protocol,
                Ip = uri.Ip,
                Port = uri.Port
            };
    }
    public string GetServiceUrlByProtocol(string protocol=null)
    {
        var config = GetServiceUrlConfigByProtocol(protocol);
        return $"{config.Protocol}://{config.Ip}" + (config.Port.CompareString("80") ? "" : $":{config.Port}");
    }

    public string GetHealthPath(string protocol=null) => $"{GetServiceUrlByProtocol(protocol)}{SystemConstant.KEY_OF_HEALTH_CHECK_PATH}";
}