public enum JoursSemaine {
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
};

public class Program {
    public static void Main()
    {
        JoursSemaine today = JoursSemaine.Lundi;
        Console.WriteLine("Nous sommes " + today);
    }
};