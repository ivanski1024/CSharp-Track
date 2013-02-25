using System;
class CallHistoryTest
{
    private static GSM myPhone = new GSM("B2100", "Samsung", "Ivan Petrov", new Battery("1000 mAh battery", 600, 9, Battery.BatteryType.LiIon), new Display(1.77, 26000));
    public static void Test()
    {
        myPhone.AddCall(new Call(DateTime.Now, "+359883431669", 60));
        myPhone.AddCall(new Call(DateTime.Now, "+359883431669", 30));
        myPhone.AddCall(new Call(DateTime.Now, "+359883431669", 135));
        myPhone.AddCall(new Call(DateTime.Now, "+359883431669", 24));
        Console.WriteLine("Current total price of Call History: {0}", myPhone.TotalPrice(0.37));

        Call maxCall = new Call(DateTime.Now, "", 0);
        int maxDuration = 0;

        for (int i = 0; i < myPhone.CallHistory.Count; i++)
        {
            if (i == 0)
            {
                maxCall = myPhone.CallHistory[i];
                maxDuration = maxCall.CallDuration;
            }
            else
            {
                if (myPhone.CallHistory[i].CallDuration > maxDuration)
                {
                    maxCall = myPhone.CallHistory[i];
                    maxDuration = maxCall.CallDuration;
                }
            }
        }
        
        myPhone.RemoveCall(maxCall);

        Console.WriteLine("Current total price of Call History after removing the longest call: {0}", myPhone.TotalPrice(0.37));

        myPhone.ClearCallHistory();

        Console.WriteLine("Current total price of Call History after clearing call history: {0}", myPhone.TotalPrice(0.37));

    }
}
