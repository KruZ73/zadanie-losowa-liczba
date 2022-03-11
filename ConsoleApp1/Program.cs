Random a = new Random();


int liczba1 = a.Next(1, 10);
int x = 0;


Console.WriteLine("Wylosowano liczbę");
Console.WriteLine("Następna liczba będzie wyższa czy niższa?");
Console.WriteLine("Wybierz liczbę od 1 do 10 na klawiaturze");



while (true)
{
    string decyzja = Console.ReadLine();
    
    
    if (!Int32.TryParse(decyzja, out x))
    {
        Console.WriteLine("Spróbuj zgadnąć liczbę ");
        continue;
    }
    if (x == liczba1)
    {
        Console.WriteLine("Brawo! Trafiłeś!");
        break;
    }
    else if (x > liczba1)
    {
        Console.WriteLine("Wylosowaa liczba jest mnniejsza");
        continue;
    }
    else if (x < liczba1)
    {
        Console.WriteLine("Wylosowana liczba jest większa");
        continue;
    }
    
}
