namespace AsalMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi Giriniz :");
            int sayi = int.Parse(Console.ReadLine());

            if(AsalMidir(sayi))
            {
                Console.WriteLine($"{sayi} bir asal sayidir.");

            }
            else
            {
                Console.WriteLine($"{sayi} bir asal sayi degildir.");
            }

        }
        static bool AsalMidir(int sayi)
        {
            if (sayi <= 1)
            {
                return false;
            }

            for (int i=2; i <= Math.Sqrt(sayi); i++) //sayinin karekoku alinir ve i'den karekokun tam sayi degerine kadar i'yi birer artirarak tek tek bolunerek kontrol edilir
            {
                if (sayi % i == 0)
                {
                    return false;
                }

            }
            return true;
        }





    }
}
