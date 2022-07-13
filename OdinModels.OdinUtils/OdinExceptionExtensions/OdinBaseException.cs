using System.ComponentModel;

namespace OdinModels.OdinUtils.OdinExceptionExtensions
{
    public class EnumOdinException
    {
        /// <summary>
        /// param can not be null
        /// </summary>
        [Description("param can not be null")] public static EnumException ParamNotNull;
        /// <summary>
        /// param can not be null
        /// </summary>
        [Description("parameter validation failed")] public static EnumException ParamValidationFailed;
        /// <summary>
        /// parameter type Incorrect
        /// </summary>
        [Description("parameter type Incorrect")] public static EnumException ParamTypeIncorrect;
        /// <summary>
        /// param can not less than or equal to zero
        /// </summary>
        [Description("parameter out of range")] public static EnumException ParamOutOfRang;
        /// <summary>
        /// param can not less than or equal to zero
        /// </summary>
        [Description("param can not Less than or equal to zero")] public static EnumException ParamNotLteZero;
        /// <summary>
        /// param can not less than to zero
        /// </summary>
        [Description("param can not Less than or equal to zero")] public static EnumException ParamNotLtZero;
        /// <summary>
        /// param can not Greater than or equal to zero
        /// </summary>
        [Description("param can not Greater than or equal to zero")] public static EnumException ParamNotGteZero;
        /// <summary>
        /// param can not Greater than to zero
        /// </summary>
        [Description("param can not Greater than or equal to zero")] public static EnumException ParamNotGtZero;


        #region OdinModels.Core
        /// <summary>
        /// Config Url is undefind
        /// </summary>
        [Description("Config Url is undefind")] public static EnumException GetServiceUrlConfigByProtocol;

        #endregion

        #region OdinModels.OdinUtils

        /// <summary>
        /// Invalid XML RSA key
        /// </summary>
        [Description("Invalid XML RSA key")] public static EnumException FromXmlStringEx;

        /// <summary>
        /// Invalid Public Key
        /// </summary>
        [Description("Invalid Public Key")] public static EnumException RsaEncrypt;
        /// <summary>
        /// Invalid Private Key
        /// </summary>
        [Description("IInvalid Private Key")] public static EnumException RsaDecrypt;

        /// <summary>
        /// key 需要 32 位长度
        /// </summary>
        [Description("key 需要 32 位长度")] public static EnumException EncryptByAesX01;
        /// <summary>
        /// 如要使用 aes_ai 偏移量参数，必须要有加密盐值参数 key
        /// </summary>
        [Description("如要使用 aes_ai 偏移量参数，必须要有加密盐值参数 key")] public static EnumException EncryptByAesX02;
        /// <summary>
        /// aes_ai 需要 16 位长度
        /// </summary>
        [Description("aes_ai 需要 16 位长度")] public static EnumException EncryptByAesX03;

        /// <summary>
        /// key 需要 32 位长度
        /// </summary>
        [Description("key 需要 32 位长度")] public static EnumException DecryptByAesX01;
        /// <summary>
        /// 如要使用 aes_ai 偏移量参数，必须要有加密盐值参数 key
        /// </summary>
        [Description("如要使用 aes_ai 偏移量参数，必须要有加密盐值参数 key")] public static EnumException DecryptByAesX02;
        /// <summary>
        /// aes_ai 需要 16 位长度
        /// </summary>
        [Description("aes_ai 需要 16 位长度")] public static EnumException DecryptByAesX03;



        #endregion

        #region regex

        /// <summary>
        /// 邮箱格式不正确
        /// </summary>
        [Description("邮箱格式不正确")] public static EnumException RegexEmail;
        /// <summary>
        /// 身份证格式不正确
        /// </summary>
        [Description("邮箱格式不正确")] public static EnumException RegexIdCardNumber;

        /// <summary>
        /// 移动电话号码格式不正确
        /// </summary>
        [Description("邮箱格式不正确")] public static EnumException RegexPhoneNumber;

        #endregion
    }
}