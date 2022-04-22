using System;
using System.Collections.Generic;

public class PieceHandler
{
    public Piece p = new Piece();
    public Dictionary<string, int[,]> pieceList = new Dictionary<string, int[,]>();

    public PieceHandler()
    {
        pieceList.Add("I", new int[,]
        {
            {1},
            {1},
            {1},
            {1}
        });
        pieceList.Add("L", new int[,]
        {
            {1, 0},
            {1, 0},
            {1, 1}
        });
        pieceList.Add("J", new int[,]
        {
            {0, 1},
            {0, 1},
            {1, 1}
        });
        pieceList.Add("S", new int[,]
        {
            {0, 1, 1},
            {1, 1, 0}
        });
        pieceList.Add("Z", new int[,]
        {
            {1, 1, 0},
            {0, 1, 1}
        });
        pieceList.Add("O", new int[,]
        {
            {1, 1},
            {1, 1}
        });
        pieceList.Add("T", new int[,]
        {
            {1, 1, 1},
            {0, 1, 0}
        });
    }

    public Piece GetRandomPiece()
    {
        Random gen = new Random();
        List<int[,]> arr = new List<int[,]>(pieceList.Values);

        Piece ranPiece = new Piece
        {
            x = 6,
            y = 0,
            // shape = arr[gen.Next(arr.Count)]
            shape = pieceList["I"]
        };

        return ranPiece;
        // return pieceList["I"];
    }
}
