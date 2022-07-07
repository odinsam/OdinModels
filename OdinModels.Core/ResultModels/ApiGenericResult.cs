using System;
using OdinModels.Core.Enums;

namespace OdinModels.Core.ResultModels
{
    /// <summary>
    /// 方法返回类型
    /// </summary>
    /// <typeparam name="T">Data 泛型类型</typeparam>
    public class ApiResult<T>
    {
        /// <summary>
        /// 方法返回数据
        /// </summary>
        public T Data { get; set; } = default(T);
        /// <summary>
        /// 方法返回信息
        /// </summary>
        public string Message { get; set; } = null;

        /// <summary>
        /// 方法返回结果标识
        /// </summary>
        private int _code;
        public int Code 
        {
            get => _code;
            set
            {
                try
                {
                    EnumResult result = (EnumResult)value;
                    _code = value;
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
            T data=default(T),
            string message=null,
            EnumResult enumResult=EnumResult.Success,
            Exception error=null)
        {
            Data = data;
            Message = message;
            Code = (int)enumResult;
            Error = error;
        }
    }
}