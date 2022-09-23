namespace metotlarOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";


            bool sonuc = int.TryParse(sayi,out int outSayi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı");
                System.Console.WriteLine(outSayi);
            }
            else
            System.Console.WriteLine("Başarısız");


            Methotlar instance=new Methotlar();
            instance.Topla(1,3,out int  result);
            System.Console.WriteLine(result);

            //Method overloading

            int ifade=999;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("HüseyinÇoban");
            
        }
 
    }
    class Methotlar
    {
        public void Topla(int a,int b,out int toplam)
        {
            toplam=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            System.Console.WriteLine(veri1+veri2);
        }
    }
}