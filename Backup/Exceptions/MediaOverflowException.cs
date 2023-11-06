namespace Backup.Exceptions;

public class MediaOverflowException : ApplicationException
{
    public MediaOverflowException(string message = "Copy size bigger than media size") : base(message)
    {

    }
}
