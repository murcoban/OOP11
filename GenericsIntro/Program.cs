using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Murat");
            Console.WriteLine(isimler.Length);
            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);

            Console.ReadKey();

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
           
        } 
    }
}
