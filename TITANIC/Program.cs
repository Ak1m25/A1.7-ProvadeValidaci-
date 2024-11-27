namespace TITANIC;

internal class Program
{
    static void Main(string[] args)
    {
        const string FILENAME = "BARCOS2.txt";
        StreamReader sRVaixells = new StreamReader(FILENAME);
        string nomVaixells = "";
        string linia;
        double latitud = 0, longitud = 0;
        int vaixellsEnfonsats = 0;
        bool trobat = false;

        linia = sRVaixells.ReadLine();

        while (!trobat && linia != null)
        {
            nomVaixells = linia;
         
            latitud = Convert.ToDouble(sRVaixells.ReadLine());
            longitud = Convert.ToDouble(sRVaixells.ReadLine());

            if (nomVaixells == "TITANIC")
            {
                trobat = true;
            }
            else vaixellsEnfonsats++; 
            
            linia = sRVaixells.ReadLine();

        }
        sRVaixells.Close();

        if (trobat) Console.WriteLine($"TITANIC TROBAT EN LES COORDENADES ({latitud}, {longitud})");
        else Console.WriteLine($"TROBATS {vaixellsEnfonsats} BARCOS ENFONSATS PERÒ CAP ÉS EL TITANIC");
    }
}
