using Backup.Exceptions;
using Backup.Models;

int idx = 0;
char[] arr = { '>', ' ', ' ' };

void Swap(ref char sym1, ref char sym2) =>
    (sym1, sym2) = (sym2, sym1);


StorageMedia storageMedia = new StorageMedia();

do
{
    Console.WriteLine("You choose backup disk");
    Console.WriteLine($"{arr[0]} DVD disk");
    Console.WriteLine($"{arr[1]} FlashStorage");
    Console.WriteLine($"{arr[2]} HDD storage");

    var keyInfo = Console.ReadKey();

    Console.Clear();

    if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        if (idx < 2)
            Swap(ref arr[idx], ref arr[++idx]);
    }
    else if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        if (idx > 0)
            Swap(ref arr[idx], ref arr[--idx]);
    }
    else if (keyInfo.Key == ConsoleKey.Enter)
    {
        switch (idx)
        {
            case 0:

                char[] menu1 = new char[storageMedia.DVDs.Length];

                for (int i = 0; i < menu1.Length; i++)
                {
                    menu1[i] = ' ';
                }

                menu1[0] = '>';
                int dvdIndex = 0;

                do
                {
                    for (int i = 0; i < storageMedia.DVDs.Length; i++)
                    {
                        Console.WriteLine($"{menu1[i]} {storageMedia.DVDs[i].MediaName} {storageMedia.DVDs[i].Model}");
                    }

                    var keyInfo1 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo1.Key == ConsoleKey.DownArrow)
                    {
                        if (dvdIndex < menu1.Length - 1)
                            Swap(ref menu1[dvdIndex], ref menu1[++dvdIndex]);
                    }
                    else if (keyInfo1.Key == ConsoleKey.UpArrow)
                    {
                        if (dvdIndex > 0)
                            Swap(ref menu1[dvdIndex], ref menu1[--dvdIndex]);
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        char[] arr2 = { '>', ' ', ' ', ' ' };
                        int idx2 = 0;

                        do
                        {
                            Console.WriteLine("Secim edin");
                            Console.WriteLine($"{arr2[0]} Media Capacity");
                            Console.WriteLine($"{arr2[1]} Copy");
                            Console.WriteLine($"{arr2[2]} FreeMemory");
                            Console.WriteLine($"{arr2[3]} PrintDeviceİnfo");

                            var keyInfo2 = Console.ReadKey();

                            Console.Clear();

                            if (keyInfo2.Key == ConsoleKey.DownArrow)
                            {
                                if (idx2 < 3)
                                    Swap(ref arr2[idx2], ref arr2[++idx2]);
                            }
                            else if (keyInfo2.Key == ConsoleKey.UpArrow)
                            {
                                if (idx2 > 0)
                                    Swap(ref arr2[idx2], ref arr2[--idx2]);
                            }
                            else if (keyInfo2.Key == ConsoleKey.Enter)
                            {
                                DVD dvd = storageMedia.DVDs[dvdIndex];

                                switch (idx2)
                                {

                                    case 0:
                                        Console.WriteLine(dvd.MediaSize);
                                        break;
                                    case 1:
                                        try
                                        {
                                            dvd.Copy(5.7f);
                                        }
                                        catch (DataSmallerThanZeroException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        catch (MediaOverflowException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        break;
                                    case 2:
                                        dvd.FreeMemory();
                                        break;
                                    case 3:
                                        dvd.PrintDeviceİnfo();

                                        break;
                                }
                            }
                        } while (true);
                    }
                } while (true);
            case 1:
                char[] menu2 = new char[storageMedia.FlashDisks.Length];

                for (int i = 0; i < menu2.Length; i++)
                {
                    menu2[i] = ' ';
                }

                menu2[0] = '>';
                int flashDiskIndex = 0;

                do
                {
                    for (int i = 0; i < storageMedia.FlashDisks.Length; i++)
                    {
                        Console.WriteLine($"{menu2[i]} {storageMedia.FlashDisks[i].MediaName} {storageMedia.FlashDisks[i].Model}");
                    }

                    var keyInfo3 = Console.ReadKey();

                    Console.Clear();

                    if (keyInfo3.Key == ConsoleKey.DownArrow)
                    {
                        if (flashDiskIndex < menu2.Length - 1)
                            Swap(ref menu2[flashDiskIndex], ref menu2[++flashDiskIndex]);
                    }
                    else if (keyInfo3.Key == ConsoleKey.UpArrow)
                    {
                        if (flashDiskIndex > 0)
                            Swap(ref menu2[flashDiskIndex], ref menu2[--flashDiskIndex]);
                    }
                    else if (keyInfo3.Key == ConsoleKey.Enter)
                    {
                        char[] arr3 = { '>', ' ', ' ', ' ' };
                        int idx4 = 0;

                        do
                        {
                            Console.WriteLine("Secim edin");
                            Console.WriteLine($"{arr3[0]} Media Capacity");
                            Console.WriteLine($"{arr3[1]} Copy");
                            Console.WriteLine($"{arr3[2]} FreeMemory");
                            Console.WriteLine($"{arr3[3]} PrintDeviceİnfo");

                            var keyInfo4 = Console.ReadKey();

                            Console.Clear();

                            if (keyInfo4.Key == ConsoleKey.DownArrow)
                            {
                                if (idx4 < 3)
                                    Swap(ref arr3[idx4], ref arr3[++idx4]);
                            }
                            else if (keyInfo4.Key == ConsoleKey.UpArrow)
                            {
                                if (idx4 > 0)
                                    Swap(ref arr3[idx4], ref arr3[--idx4]);
                            }
                            else if (keyInfo4.Key == ConsoleKey.Enter)
                            {
                                FlashDisk flashDisk = storageMedia.FlashDisks[flashDiskIndex];

                                switch (idx4)
                                {
                                    case 0:
                                        Console.WriteLine(flashDisk.MediaSize);
                                        break;
                                    case 1:
                                        try
                                        {
                                            flashDisk.Copy(5.7f);
                                        }
                                        catch (DataSmallerThanZeroException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        catch (MediaOverflowException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        break;
                                    case 2:
                                        flashDisk.FreeMemory();
                                        break;
                                    case 3:
                                        flashDisk.PrintDeviceİnfo();
                                        break;
                                }
                            }
                        } while (true);
                    }
                } while (true);
            case 2:
                char[] menu3 = new char[storageMedia.HDDs.Length];
                for (int i = 0; i < menu3.Length; i++)
                {
                    menu3[i] = ' ';
                }
                menu3[0] = '>';
                int hddIndex = 0;
                do
                {
                    for (int i = 0; i < storageMedia.HDDs.Length; i++)
                    {
                        Console.WriteLine($"{menu3[i]} {storageMedia.HDDs[i].MediaName} {storageMedia.HDDs[i].Model}");
                    }
                    var keyInfo4 = Console.ReadKey();
                    Console.Clear();
                    if (keyInfo4.Key == ConsoleKey.DownArrow)
                    {
                        if (hddIndex < menu3.Length - 1)
                            Swap(ref menu3[hddIndex], ref menu3[++hddIndex]);
                    }
                    else if (keyInfo4.Key == ConsoleKey.UpArrow)
                    {
                        if (hddIndex > 0)
                            Swap(ref menu3[hddIndex], ref menu3[--hddIndex]);
                    }
                    else if (keyInfo4.Key == ConsoleKey.Enter)
                    {
                        char[] arr4 = { '>', ' ', ' ', ' ' };
                        int idx6 = 0;
                        do
                        {
                            Console.WriteLine("Secim edin");
                            Console.WriteLine($"{arr4[0]} Media Capacity");
                            Console.WriteLine($"{arr4[1]} Copy");
                            Console.WriteLine($"{arr4[2]} FreeMemory");
                            Console.WriteLine($"{arr4[3]} PrintDeviceİnfo");
                            var keyInfo5 = Console.ReadKey();
                            Console.Clear();
                            if (keyInfo5.Key == ConsoleKey.DownArrow)
                            {
                                if (idx6 < 3)
                                    Swap(ref arr4[idx6], ref arr4[++idx6]);
                            }
                            else if (keyInfo5.Key == ConsoleKey.UpArrow)
                            {
                                if (idx6 > 0)
                                    Swap(ref arr4[idx6], ref arr4[--idx6]);
                            }
                            else if (keyInfo5.Key == ConsoleKey.Enter)
                            {
                                HDD hdd = storageMedia.HDDs[hddIndex];
                                switch (idx6)
                                {
                                    case 0:
                                        Console.WriteLine(hdd.MediaSize);
                                        break;
                                    case 1:
                                        try
                                        {
                                            hdd.Copy(5.7f);
                                        }
                                        catch (DataSmallerThanZeroException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        catch (MediaOverflowException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                        break;
                                    case 2:
                                        hdd.FreeMemory();
                                        break;
                                    case 3:
                                        hdd.PrintDeviceİnfo();
                                        break;
                                }
                            }
                        } while (true);
                    }
                } while (true);
        }
    }

} while (true);