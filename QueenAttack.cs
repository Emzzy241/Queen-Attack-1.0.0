using System;
using System.Collections.Generic;


class QueenAttack
{

    static void Main()
    {
        
        // First stage Of Application tells user to input an x, y coordinate for the Queen chess piece

        Console.WriteLine("Welcome My Dear User to the Queen Attack By Dynasty");

        Console.WriteLine("Please Input an X and Y Coordinate for the Queen FORMT: 1,2 for x,y");

        // picking up the coordinate and storing it up
        string QueenCoordinatesString = Console.ReadLine();

        // changing my Read value which would be in strings to integer

        int QueenCoordinatesInteger = int.Parse(QueenCoordinatesString);

        // INSTRUCTION SAYS: when user submits the coordinates, the program should create an instance of a Queen class with properyies for its X and Y coordinates

        // THE Queen class should have a method that takes X and a Ycoordinate as arguments, and returns true if the queen
        // can attack the given space, and false if it cannot
        // Lastly, a message should be displayed to inform the user of the results

        // CREATING MY QUEEN CLASS

        // Queen queenClass = new Queen()



        // FOR ANOTHER CHESS PIECE 

        Console.WriteLine("Please Input an X and Y Coordinate for Another Chess Piece FORMaT: 1,2 for x,y");

        // picking up the coordinates for another chess piece and storing it up
        string AnotherPieceCoordinateString = Console.ReadLine();

        int AnotherPieceCoordinateInteger = int.Parse(AnotherPieceCoordinateString);

        
        
        
    }
}