using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    /*
     * İnterfaceleri birbirinin alternatifi olan ancak kod içerikleri farklı olan durumlar için kullanırız.
     * İnterface içinde sadece imza metotları olur(kalıp-şablon) içi dolu olamaz çünkü onları biz özelleştiririz.
    */
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

    }
}
