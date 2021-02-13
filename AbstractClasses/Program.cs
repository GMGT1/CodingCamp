using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1();
            derivedClass.method2();
        }
    }

    /*
    Tamamen kalıtım amaçlı kullandığımız temel sınıfları oluştururken
    Abstract anahtar sözcüğünü kullanırız. Abstract bir sınıf oluşturabilmek
    için erişim belirtecinden sonra "abstract" anahtar sözcüğünü yazmamız
    gerekmektedir. Abstract sınıflar içerisinde hem metot tanımlayabilir 
    hem de interfacelerde oluğu gibi metot bildirimi yapabiliriz.
     */

    /* 
            (ABSTRACT SINIFLARIN NORMAL SINIFLARDAN FARKI)
    1) Normal sınıflar içerisinde metot bildirimi yapılamazken,
    Abstract sınıflar içerisinde tıpkı arayüzlerde olduğu gibi metot 
    bildirimi yapılabilir. Bildirimi yapılan metotlar, Abstract sınıftan
    türeyen sınıflar içerisinde tanımlanmak zorundadır.
    
    2) Normal sınıflardan "new" anahtar sözcüğü ile nesneler oluşturulabilir
    ancak Abstract sınıflar tamamen kalıtım amaçlı geliştirildiğinden 
    Abstract sınıflardan nesne oluşturulamaz.
    */

    /*      
            (ABSTRACT SINIFLARIN ARAYÜZLERDEN FARKI)
    1) Arayüzlerde sadece metot bildirimi yapılabilirken Abstract sınıflarda 
    hem metot bildirimi yapılabilir hem de metot tanımlanabilir.

    2) Bir sınıfa sadece bir tane Abstract sınıf inherit edilebilir ancak aynı
    sınıfa birden fazla interface implement edilebilir. ANCAK: Bir Abstract sınıfa,
    başka bir Abstract sınıfı inherit ederek bu kısıtı kaldırmak mümkün.
    
     */

    //(AYRINTI)- Bir abstract sınıfa, başka bir abstract sınıfı inherit edebiliriz.

    /*
     Eğer bir metot tüm türetilmiş sınıflarda aynı şekilde tanımlanıyorsa
     o metodu abstract sınıf içerisinde standart bir metot tanımlar gibi tanımlarız.
     */

    /*
     Eğer bir metot bir çok türetilmiş sınıfta aynı şekilde tanımlanıyor iken
     sadece bir kaçında değişik şeklde tanımlanıyorsa o metot abstract sınıf 
     içerisinde virtual olarak tanımlanır.
    */

    /*
     Eğer bir metot tüm türetilmiş sınıflarda farklı şekilde 
     tanımlanıyorsa o metodun abstract sınıf içerisinde sadece 
     bildirimi yapılır.   
     */

    public abstract class MainClass
    {
        public void Method1()
        {
            Console.WriteLine("Abstract sınıf içerisinde tanımlanmıi metot.");
        }

        public abstract void method2();
        /* 
         * metot1 türetilen sınıflara doğrudan aktarılır 
         * metot2 sınıflar içerisinde yeniden tanımlanıp içinin doldurulması gerekmektedir.
         */
    }

    class DerivedClass : MainClass
    {
        /*
         Abstract sınıf içerisinde bildirimi yapılmış olan metotları
         türetilmiş sınıflar içerisinde tanımlayabilmemiz için override 
         anahtar sözcüğünü kullanmamız gerekir.
        */
        public override void method2()
        {
            Console.WriteLine("Türetilmiş sınıf içerisinde tanımlanmış metot.");
        }
    }
}
