namespace GSM.Tests
{
    using System;

    using GSM.Components;

    public static class GSMTest
    {
        public static void DevicesTest()
        {
            GSM[] phoneArray =
            {
                new GSM("Iphone 6S", "Apple", 800, "Pesho", new Battery(BatteryType.NiCd, 72, 48), new Display(5.5, 16000000)),
                new GSM("Galaxy S7", "Samsung", 700, "Stoycho", new Battery(BatteryType.Li_Ion, 48, 24), new Display(5.7, 16000000)),
                new GSM("Galaxy Note 5", "Samsung", 650, "Kiro", new Battery(BatteryType.NiMH, 60, 36), new Display(5.9, 15000000))
            };

            foreach (var phone in phoneArray)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
