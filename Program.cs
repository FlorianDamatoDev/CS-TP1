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
    public static void Main() {

//-------//
// EXO 1 //
//-------//

        JoursSemaine today = JoursSemaine.Lundi;
        Console.WriteLine("Nous sommes " + today);

//-------//
// EXO 2 //
//-------//

        // int[,] Tableau = new int[1, 2];
        // C'est un tableau de 1x2

        // int[,,] Tableau = new int[5, 2, 3];
        // C'est 5 tableaux de 2x3

        // Matrice 3x3
        int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        // Parcours du tableau multidimensionnel avec des boucles for
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        // La méthode GetLength retourne la longueur de la dimension spécifiée du tableau multidimensionnel
        // 0 pour la première dimension, 1 pour la seconde
        // Dans ce cas, nous parcourons d'abord toutes les lignes du tableau (boucle externe for)
        // Et pour chaque ligne, nous parcourons toutes les colonnes (boucle interne for)

//-------//
// EXO 3 //
//-------//

        Console.Write("Entrez un nombre entier : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Entrez un autre nombre entier : ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2) {
            Console.WriteLine("Le plus grand nombre est : " + num1);
        } else {
            Console.WriteLine("Le plus grand nombre est : " + num2);
        }

//-------//
// EXO 4 //
//-------//

        Console.WriteLine("Entrez votre note d'examen (sur 100) :");
        int noteExam = int.Parse(Console.ReadLine());

        if (noteExam >= 60) {
            Console.WriteLine("Pass");
        } else {
            Console.WriteLine("Fail");
        }

//-------//
// EXO 5 //
//-------//

        Random random = new Random();
        int number = random.Next(1, 101); // génère un nombre aléatoire entre 1 et 100

        Console.WriteLine("Devinez le nombre compris entre 1 et 100 :");
        int res = int.Parse(Console.ReadLine());

        while (res != number) {
            Console.WriteLine("Incorrect, try again.");
            res = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Correct !");

//-------//
// EXO 6 //
//-------//

        Console.WriteLine("Entrez un nombre :");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++) {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }

//-------//
// EXO 7 //
//-------//

        int product;
        do {
            Console.WriteLine("Entrez le premier nombre :");
            int numb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le second nombre :");
            int numb2 = int.Parse(Console.ReadLine());

            product = numb1 * numb2;
            Console.WriteLine($"Le produit des deux nombres est : {product}");
        } while (product <= 1000);

//-------//
// EXO 8 //
//-------//

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }

//-------//
// EXO 9 //
//-------//

        int[] tabNumbers = new int[10];

        Console.WriteLine("Veuillez entrer 10 nombres :");
        for (int i = 0; i < 10; i++) {
            Console.Write("Numéro {0} : ", i + 1);
            tabNumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Voici les nombres que vous avez entrés :");
        foreach (int tabNumber in tabNumbers) {
            Console.WriteLine(tabNumber);
        }

//--------//
// EXO 10 //
//--------//

        string[] colors = new string[] { "rouge", "vert", "bleu", "jaune", "orange" };

        int i = 0;
        while (i < colors.Length)
        {
            Console.WriteLine(colors[i]);
            i++;
        }

//--------//
// EXO 11 //
//--------//

        double[] values = new double[] { 1.5, 2.5, 3.5, 4.5, 5.5 };

        int k = 0;
        double sum = 0;
        do {
            sum += values[k];
            i++;
        } while (i < values.Length);

        Console.WriteLine("La somme des valeurs du tableau est : {0}", sum);

//--------//
// EXO 12 //
//--------//

        int[] n = new int[20];
        for (int l = 0; l < 20; l++) {
            numbers[l] = l + 1;
        }

        for (int l = 0; l < 20; l++) {
            if (numbers[l] % 3 == 0 && numbers[l] % 5 == 0) {
                Console.WriteLine("Le premier nombre divisible par 3 et 5 est: " + numbers[l]);
                break;
            }
        }

    }
};