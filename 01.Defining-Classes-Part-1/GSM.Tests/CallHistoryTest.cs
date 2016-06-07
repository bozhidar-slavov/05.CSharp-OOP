namespace GSM.Tests
{
    using System;

    using GSM.Components;

    public static class CallHistoryTest
    {
        public static void CallHistory()
        {
            GSM callTest = new GSM("3310", "Nokia", 10, "Stamat", new Battery(BatteryType.Unknown, 999999999, 99999999), new Display(1, 2));
            callTest.AddCall(DateTime.Now, "0888888888", 360);
            callTest.AddCall(new DateTime(2016, 6, 6, 12, 35, 10), "0877777777", 956);
            callTest.AddCall(new DateTime(2016, 7, 6, 20, 10, 32), "0877777777", 1082);

            Console.WriteLine("Call history:");
            Console.WriteLine(callTest.CallHistory);
            Console.WriteLine("Price for calls:");
            Console.WriteLine("${0:F2}", callTest.GetPrice());

            callTest.RemoveLongestCall();
            Console.WriteLine("Price after removed longest call:");
            Console.WriteLine("${0:F2}", callTest.GetPrice());

            callTest.ClearHistory();
            Console.WriteLine(callTest.CallHistory);
        }
    }
}
