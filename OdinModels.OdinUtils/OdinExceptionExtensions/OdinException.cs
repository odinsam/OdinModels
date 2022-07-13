using System;
using System.ComponentModel;
using OdinModels.OdinUtils.OdinExtensions;

namespace OdinModels.OdinUtils.OdinExceptionExtensions;

public class OdinException : Exception
{
    public OdinException(EnumException enumException) : base(enumException.GetDescription())
    {
    }
    public OdinException(EnumException enumException,string msg) : base(string.Format(enumException.GetDescription(),msg))
    {
    }

    public OdinException(string errorMessage) : base(errorMessage)
    {
    }
    
}