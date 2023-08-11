using System.Runtime.Serialization;

namespace microOndas.Exceptions

{ [Serializable]
internal class MicroOndasException : Exception
{
    public MicroOndasException()
    {
    }

    public MicroOndasException(string? message) : base(message)
    {
    }

    public MicroOndasException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MicroOndasException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
}