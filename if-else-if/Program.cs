namespace if_else_if

{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<11)
            {
                Console.WriteLine("günaydın");
            }
            else if (time<=18)
            {
               Console.WriteLine("iyi günler"); 
            }
            else 
            {
                Console.WriteLine("iyi geceler");
            }

            string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);
            sonuc = time > 06 && time < 11 ? "gunyadin" :
                time <= 18 ? "iyi günler" : "iyi geceler"; //Burada soru işareti if demektik. : de else demek  
Console.WriteLine(sonuc);
        }
    }
}