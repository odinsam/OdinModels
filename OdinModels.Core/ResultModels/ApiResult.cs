using System;
using OdinModels.Core.Enums;

namespace OdinModels.Core.ResultModels
{
    /// <summary>
    /// 方法返回类型
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// 方法返回信息
        /// </summary>
        public string Message { get; set; } = null;

        /// <summary>
        /// 方法返回结果标识
        /// </summary>
        private int code;
        public int Code 
        {
            get { return code; }
            set
            {
                try
                {
                    EnumResult result = (EnumResult)value;
                }
                catch
                {
                    throw new Exception($"Code 的值必须是 {typeof(EnumResult).FullName} 中的值");
                }
            }
        }
        /// <summary>
        /// 返回异常对象
        /// </summary>
        public Exception Error { get; set; } = null;

        public ApiResult(
            string message=null,
            EnumResult enumResult=EnumResult.Success,
            Exception error=null)
        {
            Message = message;
            Code = (int)enumResult;
            Error = error;
        }
    }
}