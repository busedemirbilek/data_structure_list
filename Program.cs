using System;

namespace data_str
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU = LİSTENİN İLK ELEMANINI DELETE ETMEK
            class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                //Listenin ilk elemanını delete (iptal) edelim.
                head = head.next; // bu satır sayesinde ilk eleman gitti 0 yerine 1 den
                başlıyor yani
            tekli temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
            //SORU = LİSTENİN 2.BLOĞUNU DELETE ETMEK
            class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                // 2.bloğu delete etmek
                head.next = head.next.next;// 0-2-3-4 şeklinde ilerler 1 gitti
                tekli temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
            //SORU = 20.BLOĞU SİLEN KODLARI YAZIN
            class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                //20.bloğu delete eden kodları yazınız.
                int adet = 0;

                tekli temp = head;
                while (adet < 19)
                {
                    adet++;
                    temp = temp.next;
                }
                temp.next = temp.next.next;
                temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
             //SORU = SON BLOĞU SİLEN KODU YAZINIZ
              class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                tekli temp = head;
                //LİSTENİN SON BLOĞUNU SİLİNİZ
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                //bu kısımda liste ekrana yazılıyor
                temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
             //SORU = 77.ELEMANI SİLİNİZ
            class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                tekli temp = head;
                //77.elemanını siliniz
                while (temp.next.next != null)
                {
                    if (temp.next.data == 77)
                    {
                        temp.next = temp.next.next;
                    }
                    else
                        temp = temp.next;
                }

                //bu kısımda liste ekrana yazılıyor
                temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
             //SORU = LİSTENİN SONUNA BİR ELEMAN EKLE
            class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                tekli temp = head;
                //LİSTENİN SONUNA BİR ELEMAN EKLEYELİM
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                tekli tt = new tekli();
                tt.data = 123456;
                temp.next = tt;
                //bu kısımda liste ekrana yazılıyor
                temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
               //SORU = DATASI 77 OLAN BLOKTAN SONRA YENİ BİR BLOK EKLEYİNİZ
            class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                tekli temp = head;
                //DATASI 77 OLAN BLOKTAN SONRA YENİ BİR BLOK EKLEYİNİZ
                while (temp.next != null)
                {
                    if (temp.data == 77)
                    {
                        tekli tt = new tekli();
                        tt.data = 777;
                        tt.next = temp.next;
                        temp.next = tt;
                        temp = temp.next;
                    }
                    temp = temp.next;
                }

                //bu kısımda liste ekrana yazılıyor
                temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
             //SORU = ARANAN SAYIDAN ÖNCEKİ TAM SAYILARIN ADETLERİNİ GETİREN
            class tekli
        {
            public int data;
            public tekli next;
            static void Main(string[] args)
            {
                tekli head = null;
                tekli last = null;
                for (int i = 0; i < 100; i++)
                {
                    tekli t = new tekli();
                    t.data = i * 10;
                    if (head == null)
                    {
                        head = t;
                        last = t;
                    }
                    else
                    {
                        last.next = t;
                        last = t;
                    }
                }
                tekli temp = head;
                // aranan sayıdan önceki adetleri getiren
                int sayac = 0;
                int aranan = 43;
                while (temp.data < aranan)
                {
                    sayac++;
                    temp = temp.next;
                }
                Console.WriteLine(sayac);



                //bu kısımda liste ekrana yazılıyor
                temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
    }
}
