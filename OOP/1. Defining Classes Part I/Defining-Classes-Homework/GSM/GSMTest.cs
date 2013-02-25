using System;
class GSMTest
{
    public static void Test()
    {
        Battery battery = new Battery("Rechargable", 9, 300, Battery.BatteryType.LiIon);
        GSM[] GSMs = 
        {
            new GSM("3310", "Nokia", new Battery("900 mAh battery (BMC-3)", 200, 2.5, Battery.BatteryType.NiMH), new Display(1, 2)),
            new GSM("B2100", "Samsung", "Ivan Petrov", new Battery("1000 mAh battery", 600, 9, Battery.BatteryType.LiIon), new Display(1.77, 26000)),
            new GSM("Galaxy S3", "Samsung", new Battery("2100 mAh battery",  500, 21, Battery.BatteryType.LiIon), new Display(4.8, 13000000))
        };

        foreach (GSM myGSM in GSMs)
        {
            Console.WriteLine(myGSM.ToString());
        }

        GSM.IPhone4S.ToString();
    }
}
