using Backup.Exceptions;

namespace Backup.Models;

public class Storage
{
    protected float UsedSpace { get; set; } = 0f;
    public Guid Id { get; } = Guid.NewGuid();
    public string MediaName { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public float MediaSize { get; init; }
    public float SpeedOfWrite { get; init; }

    public virtual void Copy(float dataSize)
    {
        if (dataSize > 0)
        {
            throw new DataSmallerThanZeroException();
        }
        else if (this.UsedSpace + dataSize < this.MediaSize)
        {
            throw new MediaOverflowException();
        }

        this.UsedSpace += dataSize;

        Console.WriteLine("Bu qeder vaxt serf olunacaq {0}", (int)(dataSize / this.SpeedOfWrite / 3600));
    }
    public void FreeMemory()
    {
        Console.WriteLine("Bu qeder bos yer qaldi {0}", this.MediaSize - this.UsedSpace);
    }
    public virtual void PrintDeviceİnfo()
    {
        Console.WriteLine($"{this.Id} - {this.GetType().Name} - {this.MediaName} - {this.Model} - {this.MediaSize}");
    }
    public override string ToString()
    {
        return $"{MediaName} {Model}";
    }

}
