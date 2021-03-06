// using System;
// using System.Collections.Generic;
// using System.IO;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;
// using OdinModels.OdinUtils.OdinExtensions;
// using OdinModels.OdinUtils.Utils.OdinHttp.Models;
//
// namespace OdinModels.OdinUtils.Utils.OdinHttp
// {
//     public class OdinRequestParamasHelper
//     {
//         public static RequestParamsModel GetRequestParams(Controller controller = null)
//         {
//             var context = controller.HttpContext;
//             return GetRequestParams(context);
//         }
//
//         public static RequestParamsModel GetRequestParams(HttpContext context)
//         {
//             context.Request.EnableBuffering();
//             var request = context.Request;
//             JObject jobj = new JObject();
//             RequestParamsModel requestParams = new RequestParamsModel();
//             var qStr = context.Request.QueryString.ToString();
//             if (!string.IsNullOrEmpty(qStr))
//             {
//                 string param = request.QueryString.ToString().Substring(1);
//                 requestParams.RequestQueryString = param;
//             }
//             if (request.ContentType != null && request.ContentType.StartsWith("application/json"))
//             {
//                 string param = request.ReadRequestBody();
//                 requestParams.RequestJson = JsonConvert.DeserializeObject<JObject>(param);
//             }
//             if (request.ContentType != null &&
//                     (request.ContentType.StartsWith("text/plain") || request.ContentType.StartsWith("application/javascript") ||
//                     request.ContentType.StartsWith("text/html") || request.ContentType.StartsWith("application/xml")))
//             {
//                 string param = request.ReadRequestBody();
//                 requestParams.RequestFormDataString = param.Replace("\r", "").Replace("\n", "").Replace(" ", "");
//             }
//             if (request.ContentType != null && request.ContentType.StartsWith("application/x-www-form-urlencoded"))
//             {
//                 string param = request.ReadRequestBody();
//                 requestParams.RequestFormData = JsonConvert.DeserializeObject<JObject>(JsonConvert.SerializeObject(param.ConvertObjectToDictionary()));
//             }
//             if (request.ContentType != null && request.ContentType.StartsWith("multipart/form-data"))
//             {
//                 Dictionary<string, string> dic = new Dictionary<string, string>();
//                 foreach (var kv in request.Form)
//                 {
//                     dic.Add(kv.Key, kv.Value);
//                 }
//                 requestParams.RequestFormData = JsonConvert.DeserializeObject<JObject>(JsonConvert.SerializeObject(dic));
//                 List<Dictionary<string, UpLoadSmFile>> files = new List<Dictionary<string, UpLoadSmFile>>();
//                 long filesize = 0;
//                 foreach (var file in request.Form.Files)
//                 {
//                     filesize += file.Length;
//                     if (filesize > 1024 * 1024 * 4)
//                         throw new Exception("?????????????????????????????????????????????????????????????????????????????????");
//                     var fileBytes = new Byte[file.Length];
//                     MemoryStream fileStream = new MemoryStream(fileBytes);
//                     file.CopyTo(fileStream);
//                     files.Add(new Dictionary<string, UpLoadSmFile>() { { file.Name, new UpLoadSmFile { FileName = file.Name, FileContent = fileStream.ToArray(), FileSize = file.Length } } });
//                 }
//                 requestParams.RequestUploadFile = files;
//             }
//             return requestParams;
//         }
//     }
// }