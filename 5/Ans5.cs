using System;

class SecTransferMins
{
    static void Main()
    {
        Console.Write("ป้อนจำนวนวินาที: ");
        int totalSeconds = int.Parse(Console.ReadLine());

        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        string timeString = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        Console.WriteLine("ผลลัพธ์: " + timeString);
    }
}
