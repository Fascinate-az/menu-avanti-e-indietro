bool continuareCiclo = true;
int stato = 0;

while (continuareCiclo)
{
    Console.Clear();
    if (stato == 0)
    {
        introduzione();
        var scelta = int.Parse(Console.ReadLine());
        if (scelta == 1)
        {
            stato = 1; // Passa al secondo menu
        }
        else
        {
            Console.WriteLine("Opzione non valida. Riprovare.");
        }
    }
    else if (stato == 1)
    {
        Console.WriteLine("premere 1 per andare avanti 2 per tornare indietro");
        var secondaScelta = int.Parse(Console.ReadLine());
        if (secondaScelta == 1)
        {
            Console.WriteLine("sei andato avanti\nPremere 1 per tornare al menu principale\npremere 2 per chiudere");
            secondaScelta = int.Parse(Console.ReadLine());
                if(secondaScelta == 1)
            {
                stato = 0;
            }
            else if (secondaScelta == 2){
                continuareCiclo = false;
                
            }
             // Esci dal ciclo principale
        }
        else if (secondaScelta == 2)
        {
            Console.WriteLine("Stai tornando indietro.");
            stato = 0; // Torna al primo menu
            
        }
        else
        {
            Console.WriteLine("Opzione non valida. Riprovare.");
        }
    }
}

Console.ReadKey();

void introduzione()
{
    Console.WriteLine("premere 1 per accedere al menu principale");
}
