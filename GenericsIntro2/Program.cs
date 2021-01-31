using System;

namespace GenericsIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Talha");
            isimler.Add("Gamga");
            isimler.Add("Edip");
            isimler.Add("Halil");
            isimler.Show();

        }
    }
}
