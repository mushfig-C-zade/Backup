namespace Backup.Exceptions;

public class DataSmallerThanZeroException : ApplicationException
{
    public DataSmallerThanZeroException(string message = "Copied data can't be smaller than 0") : base(message)
    {

    }
}
