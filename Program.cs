using System;

namespace Project
{
  class Program
  {
    private static Candy[] candies;

    //voir description de chaque fonction avant de commencer à code 
    public static void LoadCandies()
    {
            //....
            //richTextBox1.Text = File.ReadAllText(filename);

        }
    public static int GetSelection(int count) 
    {
      //.....
      return 0;//à changer le 0 par la selection à retourner
    }

    public static Candy GetCandy( int selection ) 
    {
            return new Candy("");// à modifier new Candy("") par le bonbon à retourner
    }

    public static decimal GetCoin() 
    {

            //....
            return 0m;//à modifier le 0m par la valeur décimale du coin percu 
  
    }

    static void Main(string[] args)
    {

       // while (true) {//pour lancer la machine à l'infini jusqu'à la fermeture du programme

        //int selection; //pour récupérer la selection
        //Candy candy; //pour récupérer le bonbon choisi

                //  if(candy.Stock == 0) {
                //    Board.Print($"{candy.Name} VIDE!", selection);
                //  } else {

                //  //........
                //  Console.WriteLine("\nAppuyez sur une touche pour acheter d'autre bonbon...");
                //  Console.ReadKey();
                //fin
      //}


            //exemple de création d'une variable structuré avec le type Candy qu'on a créé
            //pour le type structuré(classe) qu'on a définit :
            //il contient la 1ere case string pour le nom du bonbon (nommée Name)
            //il contient la deuxième case Price de type decimal por stocker le prix de vente d'un tel bonbon
            //et il contient la 3eme case stock de type int pour stocker la quantité de ce bonbon qu'on a dans la machine
            Candy bonbon = new Candy("M&Ms"); //partie gauche de l'instruction : déclaration de la variable bonbon , partie droite reservation de la mémoire de la variable bonbon (même principe des tableaux quoi !)
                                              //le type Candy est définit de telle facon qu'on initialise notre variable bonbon avec son nom en premier
                                              // on peux changer son nom en utilisant le . : bonbon.Name = "ferrero rocher"

            //on accède à la case du prix pour donner une valeur de prix à notre variable bonbon
            bonbon.Price = 2m;
            //on accède à la case du Stock pour donner une valeur de quantité de stock à notre variable bonbon
            bonbon.Stock = 10;

            //comment je peux récupérer les données de mes bonbons pour les utiliser dans mon code(calcul,affichage,etc) ?!!
            //idem !
            //exemple
            Console.WriteLine(bonbon.Stock);
        }
  }
}
