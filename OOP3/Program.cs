using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManger = new TasitKrediManger();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLogerService = new DatebaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisi(),new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManger};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
