﻿public enum JoursSemaine {
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

    }
};