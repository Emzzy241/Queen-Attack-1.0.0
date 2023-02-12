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

        long QueenCoordinatesInteger = long.Parse(QueenCoordinatesString);

        




        // FOR ANOTHER CHESS PIECE 

        Console.WriteLine("Please Input an X and Y Coordinate for Another Chess Piece FORMaT: 1,2 for x,y");

        // picking up the coordinates for another chess piece and storing it up
        string AnotherPieceCoordinateString = Console.ReadLine();

        int AnotherPieceCoordinateInteger = int.Parse(AnotherPieceCoordinateString);

        
        
        
    }
}