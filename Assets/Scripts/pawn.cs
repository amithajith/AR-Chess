using UnityEngine;
using System.Collections;

public class pawn : MonoBehaviour {
	public void moves()
	{ 
		int pos = BoardManager1.pos;
		int i, j;
		i = (pos / 10)-1;
		j = (pos % 10)-1;

		if (BoardManager1.player == "white") 
		{
			if (BoardManager1.whitefirstMove == true) 
			{
				BoardManager1.possibleMoves [0] = pos - 10;
				BoardManager1.possibleMoves [1] = pos - 20;
				BoardManager1.whitefirstMove = false;
			} 
			else 
			{
				if (BoardManager1.PiecePos [i - 1, j] == null) 
				{
					BoardManager1.possibleMoves [0] = pos - 10;
				}
				if (j < 7) 
				{
					if (BoardManager1.PiecePos [i - 1, j + 1] != null && BoardManager1.PiecePos [i - 1, j + 1].transform.tag != "white") {
						BoardManager1.possibleMoves [1] = pos - 9;
					}
				}
				if (j > 0) 
				{
					if (BoardManager1.PiecePos [i - 1, j - 1] != null && BoardManager1.PiecePos [i - 1, j - 1].transform.tag != "white") {
						BoardManager1.possibleMoves [2] = pos - 11;
					}
				}
			}
		} 
		else if(BoardManager1.player == "black")
		{
			if (BoardManager1.blackfirstMove == true) {
				BoardManager1.possibleMoves [0] = pos + 10;
				BoardManager1.possibleMoves [1] = pos + 20;
				BoardManager1.blackfirstMove = false;
			}
			else 
			{
				if (BoardManager1.PiecePos [i + 1, j] == null) {
					BoardManager1.possibleMoves [0] = pos + 10;
				}
				if (j < 7) {
					if (BoardManager1.PiecePos [i + 1, j + 1] != null && BoardManager1.PiecePos [i + 1, j + 1].transform.tag != "black") {
						BoardManager1.possibleMoves [1] = pos + 11;
					}
				}
				if (j > 0) {
					if (BoardManager1.PiecePos [i + 1, j - 1] != null && BoardManager1.PiecePos [i + 1, j - 1].transform.tag != "black") {
						BoardManager1.possibleMoves [2] = pos + 9;
					}
				}
			}
		}
		for (int c = 0; c < 5; c++)
			Debug.Log (BoardManager1.possibleMoves [c]);
	}
}
