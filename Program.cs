using System;
namespace NameSpace {

    enum JoursSemaine {
        Lundi,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    };
    enum DaysOfWeek {
        Lundi = 1,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    }
    enum Temperature {
        Hot,
        Warm,
        Cool,
        Cold
    }

    public class Program {

        public static void Main(string[] args) {

            Clear();
            Console.WriteLine("Choisir une partie :");
            Console.WriteLine("1) Part 1 : Bases Algo");
            Console.WriteLine("2) Part 2 : Loops Array");
            Console.WriteLine("3) Part 3 : Enum Constantes");
            Console.WriteLine("4) Part 4 : Programmes");
            Console.Write("\r\nSelectionner une partie :");

            switch (Console.ReadLine()) {
                case "1":
                    Clear();
                    Part1();
                    break;
                case "2":
                    Clear();
                    Part2();
                    break;
                case "3":
                    Clear();
                    Part3();
                    break;
                case "4":
                    Clear();
                    Part4();
                    break;
                default:
                    break;
            }

            static void Part1() {
                Clear();
                Console.WriteLine("Choisir un exercice :");
                Console.WriteLine("1) Exercice 1 (Display the larger of the two numbers)");
                Console.WriteLine("2) Exercice 2 (Exam score (out of 100))");
                Console.WriteLine("3) Exercice 3 (Generates a random number between 1 and 100))");
                Console.WriteLine("4) Exercice 4 (Multiplication table for this number (up to 12))");
                Console.WriteLine("5) Exercice 5 (Product of the two numbers and a do-while loop)");
                Console.Write("\r\nSelectionner un exercice :");

                switch (Console.ReadLine()) {
                    case "1":
                        Clear();
                        Exercice1();
                        break;
                    case "2":
                        Clear();
                        Exercice2();
                        break;
                    case "3":
                        Clear();
                        Exercice3();
                        break;
                    case "4":
                        Clear();
                        Exercice4();
                        break;
                    case "5":
                        Clear();
                        Exercice5();
                        break;
                    default:
                        break;
                }
            }

            static void Part2() {
                Clear();
                Console.WriteLine("Choisir un exercice :");
                Console.WriteLine("1) Exercice 6 (Array of integers containing numbers from 1 to 10)");
                Console.WriteLine("2) Exercice 7 (The user to enter 10 numbers, then stores them in an array)");
                Console.WriteLine("3) Exercice 8 (Array of strings containing the names of 5 colors)");
                Console.WriteLine("4) Exercice 9 (Array of doubles containing the values 1.5, 2.5, 3.5, 4.5 and 5.5)");
                Console.WriteLine("5) Exercice 10 (Table of integers containing numbers from 1 to 20)");
                Console.Write("\r\nSelectionner un exercice :");

                switch (Console.ReadLine()) {
                    case "1":
                        Clear();
                        Exercice6();
                        break;
                    case "2":
                        Clear();
                        Exercice7();
                        break;
                    case "3":
                        Clear();
                        Exercice8();
                        break;
                    case "4":
                        Clear();
                        Exercice9();
                        break;
                    case "5":
                        Clear();
                        Exercice10();
                        break;
                    default:
                        break;
                }
            }
            
            static void Part3() {
                Clear();
                Console.WriteLine("Choisir un exercice :");
                Console.WriteLine("1) Exercice 11 (Enum for the days of the week (for example, Monday, Tuesday, etc.))");
                Console.WriteLine("2) Exercice 12 (Constant for the maximum number of days in a year (for example, 365))");
                Console.WriteLine("3) Exercice 13 (Constant for the number of seconds in a minute (for example, 60))");
                Console.WriteLine("4) Exercice 14 (Enum for the seasons of the year (for example, spring, summer, autumn, winter))");
                Console.WriteLine("5) Exercice 15 (Constant for the number of inches in a foot (for example, 12))");
                Console.Write("\r\nSelectionner un exercice :");

                switch (Console.ReadLine()) {
                    case "1":
                        Clear();
                        Exercice11();
                        break;
                    case "2":
                        Clear();
                        Exercice12();
                        break;
                    case "3":
                        Clear();
                        Exercice13();
                        break;
                    case "4":
                        Clear();
                        Exercice14();
                        break;
                    case "5":
                        Clear();
                        Exercice15();
                        break;
                    default:
                        break;
                }
            }
            
            static void Part4() {
                Clear();
                Console.WriteLine("Choisir un exercice :");
                Console.WriteLine("1) Exercice 16 (Asks the user's name and age)");
                Console.WriteLine("2) Exercice 17 (Generates and displays a multiplication table for numbers from 1 to 9)");
                Console.WriteLine("3) Exercice 18 (Asks the user to enter a series of numbers separated by commas)");
                Console.WriteLine("4) Exercice 19 (Asks the user to enter a word, then displays the word backwards)");
                Console.WriteLine("5) Exercice 20 (Generates and displays a random number between 1 and 100.)");
                Console.Write("\r\nSelectionner un exercice :");

                switch (Console.ReadLine()) {
                    case "1":
                        Clear();
                        Exercice16();
                        break;
                    case "2":
                        Clear();
                        Exercice17();
                        break;
                    case "3":
                        Clear();
                        Exercice18();
                        break;
                    case "4":
                        Clear();
                        Exercice19();
                        break;
                    case "5":
                        Clear();
                        Exercice20();
                        break;
                    default:
                        break;
                }
            }
            
            static void Clear() {
                Console.Clear();
            }

            static void ExoIntro () {

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
            }

//------- Part 1 : Bases Algo -------//

//-------//
// EXO 1 //
//-------//

            static void Exercice1() {
                Console.Write("Entrez un nombre entier : ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Entrez un autre nombre entier : ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2) {
                    Console.WriteLine("Le plus grand nombre est : " + num1);
                } else {
                    Console.WriteLine("Le plus grand nombre est : " + num2);
                }
            }

//-------//
// EXO 2 //
//-------//

            static void Exercice2() {
                Console.WriteLine("Entrez votre note d'examen (sur 100) :");
                int noteExam = int.Parse(Console.ReadLine());

                if (noteExam >= 60) {
                    Console.WriteLine("Pass");
                } else {
                    Console.WriteLine("Fail");
                }
            }

//-------//
// EXO 3 //
//-------//

            static void Exercice3() {
                Random random = new Random();
                int number = random.Next(1, 101); // génère un nombre aléatoire entre 1 et 100

                Console.WriteLine("Devinez le nombre compris entre 1 et 100 :");
                int res = int.Parse(Console.ReadLine());

                while (res != number) {
                    Console.WriteLine("Incorrect, try again.");
                    res = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Correct !");
            }

//-------//
// EXO 4 //
//-------//

            static void Exercice4() {
                Console.WriteLine("Entrez un nombre :");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 12; i++) {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
            }

//-------//
// EXO 5 //
//-------//

            static void Exercice5() {
                int product;
                do {
                    Console.WriteLine("Entrez le premier nombre :");
                    int numb1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Entrez le second nombre :");
                    int numb2 = int.Parse(Console.ReadLine());

                    product = numb1 * numb2;
                    Console.WriteLine($"Le produit des deux nombres est : {product}");
                } while (product <= 1000);
            }

//------- Part 2 : Loops Array -------//

//-------//
// EXO 1 //
//-------//

            static void Exercice6() {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                for (int i = 0; i < numbers.Length; i++) {
                    Console.WriteLine(numbers[i]);
                }
            }

//-------//
// EXO 2 //
//-------//

            static void Exercice7() {
                int[] tabNumbers = new int[10];

                Console.WriteLine("Veuillez entrer 10 nombres :");
                for (int m = 0; m < 10; m++) {
                    Console.Write("Numéro {0} : ", m + 1);
                    tabNumbers[m] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Voici les nombres que vous avez entrés :");
                foreach (int tabNumber in tabNumbers) {
                    Console.WriteLine(tabNumber);
                }
            }

//-------//
// EXO 3 //
//-------//

            static void Exercice8() {
                string[] colors = new string[] { "rouge", "vert", "bleu", "jaune", "orange" };

                int o = 0;
                while (o < colors.Length)
                {
                    Console.WriteLine(colors[o]);
                    o++;
                }
            }

//-------//
// EXO 4 //
//-------//

            static void Exercice9() {
                double[] values = new double[] { 1.5, 2.5, 3.5, 4.5, 5.5 };

                int k = 0;
                double sum = 0;
                do {
                    sum += values[k];
                    k++;
                } while (k < values.Length);

                Console.WriteLine("La somme des valeurs du tableau est : {0}", sum);
            }

//-------//
// EXO 5 //
//-------//

            static void Exercice10() {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                for (int i = 0; i < numbers.Length; i++) {
                    if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0) {
                    Console.WriteLine($"The first number divisible by 3 and 5 is: {numbers[i]}");
                    break;
                    }
                }
            }

//------- Part 3 : Enum Constantes -------//

//-------//
// EXO 1 //
//-------//

            static void Exercice11() {
                Console.Write("Enter a number representing a day of the week: ");
                int dayNumber = Convert.ToInt32(Console.ReadLine());
                DaysOfWeek day = (DaysOfWeek)dayNumber;
                Console.WriteLine(day);
            }

//-------//
// EXO 2 //
//-------//

            static void Exercice12() {
                const int MAX_DAYS_PER_YEAR = 365;
                Console.Write("Enter your age in years :");
                int ageInYears = Convert.ToInt32(Console.ReadLine());

                int daysLived = ageInYears * MAX_DAYS_PER_YEAR;

                Console.WriteLine($"You have lived for {daysLived} days.");
            }

//-------//
// EXO 3 //
//-------//

          static void Exercice13() {
                const int SECONDS_PER_MINUTE = 60;
                Console.Write("Enter the number of minutes: ");
                int minutes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of seconds: ");
                int seconds = Convert.ToInt32(Console.ReadLine());
                int totalSeconds = minutes * SECONDS_PER_MINUTE + seconds;
                
                Console.WriteLine($"{minutes} minutes and {seconds} seconds is equal to {totalSeconds} seconds.");
            }

//-------//
// EXO 4 //
//-------//

            static void Exercice14() {
                Console.Write("Enter a temperature in Celsius: ");
                double temperature = Convert.ToInt32(Console.ReadLine());

                Temperature temp;
                if (temperature > 30) {
                    temp = Temperature.Hot;
                } else if (temperature > 20) {
                    temp = Temperature.Warm;
                } else if (temperature > 10) {
                    temp = Temperature.Cool;
                } else {
                    temp = Temperature.Cold;
                }

                switch (temp) {
                    case Temperature.Hot:
                    Console.WriteLine("It's hot !");
                    break;
                    case Temperature.Warm:
                    Console.WriteLine("It's warm.");
                    break;
                    case Temperature.Cool:
                    Console.WriteLine("It's cool.");
                    break;
                    case Temperature.Cold:
                    Console.WriteLine("It's cold.");
                    break;
                }
            }

//-------//
// EXO 5 //
//-------//

            static void Exercice15() {
                const int INCHES_PER_FOOT = 12;
                Console.Write("Enter the number of feet :");
                int feet = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number of inches :");
                int inches = Convert.ToInt32(Console.ReadLine());
                int totalInches = feet * INCHES_PER_FOOT + inches;
                Console.WriteLine($"{feet} feet and {inches} inches is equal to {totalInches} inches.");
            }

//------- Part 4 : Programmes -------//

//-------//
// EXO 1 //
//-------//

            static void Exercice16() {
                Console.Write("Enter your name: ");
                string? name = Console.ReadLine();
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                int yearsLeft = 100 - age;
                Console.WriteLine($"Hello {name}, you have {yearsLeft} years left until you reach 100 years old.");
            }

//-------//
// EXO 2 //
//-------//

        static void Exercice17() {
            for (int i = 1; i <= 9; i++) {
                for (int j = 1; j <= 9; j++) {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }

//-------//
// EXO 3 //
//-------//

            static void Exercice18() {
                Console.Write("Enter a list of numbers separated by commas :");
                string? input = Console.ReadLine();
                string[] numbers = input.Split(',');
                int sumOfString = 0;
                foreach (string s in numbers) {
                    sumOfString += int.Parse(s);
                }
                Console.WriteLine($"The sum of the numbers is : {sumOfString}");
            }

//-------//
// EXO 4 //
//-------//

            static void Exercice19() {
                Console.Write("Enter a word :");
                string? word = Console.ReadLine();
                char[] wordArray = word.ToCharArray();
                Array.Reverse(wordArray);
                string reversedWord = new string(wordArray);
                Console.WriteLine($"The reversed word is : {reversedWord}");
            }

//-------//
// EXO 5 //
//-------//

            static void Exercice20() {
                Random random = new Random();
                int randomNumber = random.Next(1, 101);
                Console.WriteLine($"The random number is : {randomNumber}");
            }
        }
    }
}
