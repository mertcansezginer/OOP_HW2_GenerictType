namespace OOP_HW2_GenerictType
{
    internal class Program
    {
        
        private class GenericType<T>  // GenericType adında bir generic sınıf olusturduk
        {
            private T veri; // Generic tipinde veri alani.

            
            public GenericType(T input)  //constructor metod ile veri alanini baslatiyoruz
            {
                veri = input;
            }

            
            public T GetData() //veri ye metod disindan erismemizi sagliyoruz, yani veri yi donduruyor.
            {
                return veri;
            }
        }

        static void Main(string[] args)
        {
            // GenericType sinifini kullanarak farkli tiplerde(int ve string) veri tipi tutabiliyoruz
            GenericType<int> intData = new GenericType<int>(25); 
            GenericType<string> stringData = new GenericType<string>("Merhaba");

            // Veri cekmek icin GetData metodunu calistiriyoruz
            int intResult = intData.GetData();   //integer cagirirsak int geliyor
            string stringResult = stringData.GetData();//string cagirirsak string geliyor

            
            Console.WriteLine("Integer Veri: " + intResult);
            Console.WriteLine("String Veri: " + stringResult);
        }
    }
}
