using System;

public class Bank
{
    public static void Main(string[] args)
    {
        int amount = 8000;

        if (amount > 1000)
        {
            Console.WriteLine("จำนวนเงินต้องน้อยกว่า 1000 บาท");
        }
        else
        {
            int change = 1000 - amount;

            Console.WriteLine("คุณจะชำระเงินด้วยธนบัตร 1000 บาทและรับเงินทอนดังนี้:"+change);
            Console.WriteLine(Change(change));
        }
    }

    // แปลงเงินเป็นจำนวนแบงค์และเหรียญ
    public static string Change(int baht)
    {
        const int b500 = 500;
        const int b100 = 100;
        const int b50 = 50;
        const int b20 = 20;
        const int c10 = 10;
        const int c5 = 5;
        const int c2 = 2;
        const int c1 = 1;

        int bank500 = baht / b500;
        baht = baht % b500;

        int bank100 = baht / b100;
        baht = baht % b100;

        int bank50 = baht / b50;
        baht = baht % b50;

        int bank20 = baht / b20;
        baht = baht % b20;

        int coin10 = baht / c10;
        baht = baht % c10;

        int coin5 = baht / c5;
        baht = baht % c5;

        int coin2 = baht / c2;
        baht = baht % c2;

        int coin1 = baht / c1;
        baht = baht % c1;

        return $"\nbank500 ={bank500}\nbank100 ={bank100}\nbank50 ={bank50}\nbank20 ={bank20}\ncoin10 ={coin10}\ncoin5 ={coin5}\ncoin2 ={coin2}\ncoin1 ={coin1}";
    }
}
