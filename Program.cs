namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        
        int allLoot = 0;
        Console.WriteLine("Combien de wagons veux tu inspecter?");
        int nombreDeWagons = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < nombreDeWagons; i++)
            {
                Console.WriteLine("---- Inspection du wagon "+ (i+1) +" ----");
                for (int j = 0; j < 4; j++)
                {
                    int loot;
                    loot = Random.Shared.Next(1, 11);
                    allLoot += loot;
                    Console.WriteLine("Inspection du coffre "+ (i*4+j+1));
                    Console.WriteLine("Loot : "+ loot +" pieces");
                }
            }
        Console.WriteLine("vous avez inspecté "+ (nombreDeWagons*4)+" coffres");
        Console.WriteLine("vous avez loot "+ allLoot +" pieces");


        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.

           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.

            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */
    }
}