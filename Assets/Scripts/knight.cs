using UnityEngine;
using System.Collections;

public class knight : MonoBehaviour {
	public void moves()
	{
		int pos = BoardManager1.pos;
		int i, j, l=0;
		i = (pos / 10)-1;
		j = pos % 10;

		if (BoardManager1.player == "white") 
		{
			if ((i + 2) < 8 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i + 2, j - 1] == null || BoardManager1.PiecePos [i + 2, j - 1].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos + 19;
					l++;
				}
			}
			if ((i + 1) < 8 && (j - 2) >= 0) {
				if (BoardManager1.PiecePos [i + 1, j - 2] == null || BoardManager1.PiecePos [i + 1, j - 2].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos + 8;
					l++;
				}
			}
			if ((i + 2) < 8 && (j + 1) < 8) {
				if (BoardManager1.PiecePos [i + 2, j + 1] == null || BoardManager1.PiecePos [i + 2, j + 1].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos + 21;
					l++;
				}
			}
			if ((i + 1) < 8 && (j + 2) < 8) {
				if (BoardManager1.PiecePos [i + 1, j + 2] == null || BoardManager1.PiecePos [i + 1, j + 2].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos + 12;
					l++;
				}
			}


			if ((i - 2) >= 0 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i - 2, j - 1] == null || BoardManager1.PiecePos [i - 2, j - 1].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos - 21;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j - 2) >= 0) {
				if (BoardManager1.PiecePos [i - 1, j - 2] == null || BoardManager1.PiecePos [i - 1, j - 2].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos - 12;
					l++;
				}
			}
			if ((i - 2) >= 0 && (j + 1) < 8) {
				if (BoardManager1.PiecePos [i - 2, j + 1] == null || BoardManager1.PiecePos [i - 2, j + 1].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos - 19;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j + 2) < 8) {
				if (BoardManager1.PiecePos [i - 1, j + 2] == null || BoardManager1.PiecePos [i - 1, j + 2].transform.tag != "white") {
					BoardManager1.possibleMoves [l] = pos - 8;
					l++;
				}
			}
		} else if (BoardManager1.player == "black") 
		{
			if ((i + 2) < 8 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i + 2, j - 1] == null || BoardManager1.PiecePos [i + 2, j - 1].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos + 19;
					l++;
				}
			}
			if ((i + 1) < 8 && (j - 2) >= 0) {
				if (BoardManager1.PiecePos [i + 1, j - 2] == null || BoardManager1.PiecePos [i + 1, j - 2].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos + 8;
					l++;
				}
			}
			if ((i + 2) < 8 && (j + 1) < 8) {
				if (BoardManager1.PiecePos [i + 2, j + 1] == null || BoardManager1.PiecePos [i + 2, j + 1].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos + 21;
					l++;
				}
			}
			if ((i + 1) < 8 && (j + 2) < 8) {
				if (BoardManager1.PiecePos [i + 1, j + 2] == null || BoardManager1.PiecePos [i + 1, j + 2].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos + 12;
					l++;
				}
			}


			if ((i - 2) >= 0 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i - 2, j - 1] == null || BoardManager1.PiecePos [i - 2, j - 1].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos - 21;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j - 2) >= 0) {
				if (BoardManager1.PiecePos [i - 1, j - 2] == null || BoardManager1.PiecePos [i - 1, j - 2].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos - 12;
					l++;
				}
			}
			if ((i - 2) >= 0 && (j + 1) < 8) {
				if (BoardManager1.PiecePos [i - 2, j + 1] == null || BoardManager1.PiecePos [i - 2, j + 1].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos - 19;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j + 2) < 8) {
				if (BoardManager1.PiecePos [i - 1, j + 2] == null || BoardManager1.PiecePos [i - 1, j + 2].transform.tag != "black") {
					BoardManager1.possibleMoves [l] = pos - 8;
					l++;
				}
			}
		}
		if (BoardManager1.firstMove == true)
			BoardManager1.firstMove = false;
	}
}
