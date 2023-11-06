namespace Backup.Models;

public class StorageMedia
{

    public StorageMedia()
    {
        DVDs = new DVD[]
        {
            new DVD {MediaName ="DVD1", Model="1Face", MediaSize= 1.73f, SpeedOfWrite=0.98f },
            new DVD{MediaName="DVD2",Model="2Face",MediaSize=4.7f,SpeedOfWrite= 1.38f }
        };
        FlashDisks = new FlashDisk[]
       {
            new FlashDisk {MediaName ="FlashDisk1", Model="1Face" },
            new FlashDisk{MediaName="FlashDisk2",Model="2Face" }
       };
        HDDs = new HDD[]
       {
            new HDD {MediaName ="HDD1", Model="1Face" },
            new HDD{MediaName="HDD2",Model="2Face" }
       };
    }

    private void PlugStorage(ref Storage[] storages, Storage media)
    {
        Storage[] tmp = new Storage[storages.Length + 1];

        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = storages[i];
        }

        tmp[^1] = media;

        storages = tmp;
    }



    private void UnplugStorage(ref Storage[] storages, string id)
    {
        Storage[] tmp = new Storage[storages.Length - 1];

        for (int i = 0; i < tmp.Length - 1; i++)
        {
            if (storages[i].Id.ToString() != id)
            {
                tmp[i] = storages[i];
            }
        }

        storages = tmp;
    }

    public void AddDVD(DVD dvd)
    {
        var storages = (DVDs as Storage[]);

        PlugStorage(ref storages, dvd);
    }
    public void AddFlashDisk(FlashDisk flashDisk)
    {
        var storages = (FlashDisks as Storage[]);

        PlugStorage(ref storages, flashDisk);
    }
    public void AddHDD(HDD hdd)
    {
        var storages = (HDDs as Storage[]);

        PlugStorage(ref storages, hdd);
    }
    public void RemoveDVD(DVD dvd)
    {
        var storages = (HDDs as Storage[]);

        UnplugStorage(ref storages, dvd.Id.ToString());
    }
    public void RemoveFlashDisk(FlashDisk flashDisk)
    {
        var storages = (FlashDisks as Storage[]);

        UnplugStorage(ref storages, flashDisk.Id.ToString());
    }
    public void RemoveHDD(HDD hdd)
    {
        var storages = (HDDs as Storage[]);

        UnplugStorage(ref storages, hdd.Id.ToString());
    }

    public DVD[] DVDs { get; private set; }
    public FlashDisk[] FlashDisks { get; private set; }
    public HDD[] HDDs { get; private set; }


    public void Info()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is DVD");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (DVD dvd in DVDs)
        {
            Console.WriteLine(dvd);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Flash Disk");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (FlashDisk flashDisk in FlashDisks)
        {
            Console.WriteLine(flashDisk);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is HDD");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (HDD hdd in HDDs)
        {
            Console.WriteLine(hdd);
        }

    }

    public void ShowsAllDvd()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is DVD");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (DVD dvd in DVDs)
        {
            Console.WriteLine(dvd);
        }
    }
    public void ShowsAllFlashDIsk()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is FlashDisk");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (FlashDisk flashDisk in FlashDisks)
        {
            Console.WriteLine(flashDisk);
        }
    }

    public void ShowsAllHdd()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This is Fish");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (HDD hdd in HDDs)
        {
            Console.WriteLine(hdd);
        }
    }
}
