internal class Program
{
    private static void Main(string[] args)
    {
        const decimal PLN_na_USD = 0.2525M;
        const decimal USD_na_GBP = 0.7886M;
        const decimal USD_na_EUR = 0.9116M;
        const decimal USD_na_CHF = 0.8753M;

        Console.Write("Podaj kwote w PLN:");
        decimal PLN = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Wybierz walute (EUR, GBP, CHF):");
        string docelowaWaluta = Console.ReadLine();

        decimal przeliczUSD = PLN * PLN_na_USD;

        decimal wynik;
 
        switch (docelowaWaluta) 
        {
            case "EUR":
                wynik = przeliczUSD * USD_na_EUR;
                Console.WriteLine($"Twoja kwota po wymianie: {wynik}EUR"); 
                break;
            case "GBP":
                wynik = przeliczUSD * USD_na_GBP;
                Console.WriteLine($"Twoja kwota po wymianie: {wynik}GBP");
                break;
            case "CHF":
                wynik = przeliczUSD * USD_na_CHF;
                Console.WriteLine($"Twoja kwota po wymianie: {wynik}CHF");
                break;
                default: Console.WriteLine("Nieprawidłowy wybor waluty docelowej");
                break;
        }
       


        
        
    }

}