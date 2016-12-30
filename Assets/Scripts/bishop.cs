using UnityEngine;
using System.Collections;

public class bishop : MonoBehaviour {
	public void moves()
	{
		int pos = BoardManager1.pos;
		int i, j, l=0,m=1,n=1,o=1,p=1;
		i = (pos / 10)-1;
		j = pos % 10;
		if (BoardManager1.player == "white") 
		{
			if (i < 8 && j < 8) 
			{
				for (int k = i + 1, h = j + 1; k < 8 && h < 8; k++, h++) {
					if (BoardManager1.PiecePos [k+1, h] != null) {
						if (BoardManager1.PiecePos [k+1, h].tag == "black") {
							BoardManager1.possibleMoves [l] = pos + (m * 11);
						}
						break;
					} else {
						BoardManager1.possibleMoves [l] = pos + (m * 11);
						m++;
						l++;
					}
				}


				for (int k = i + 1, h = j - 1; k < 8 && h >= 0; k++, h--) {
					if (BoardManager1.PiecePos [k+1, h] != null) {
						if (BoardManager1.PiecePos [k+1, h].tag == "black") {
							BoardManager1.possibleMoves [l] = pos + (n * 9);
						}
						break;
					} else {
						BoardManager1.possibleMoves [l] = pos + (n * 9);
						n++;
						l++;
					}
				}
			}
			if(i > 0 && j < 8)
			for (int k = i - 1, h = j + 1; k > 0 && h < 8; k--, h++) {
				if (BoardManager1.PiecePos [k+1, h] != null) {
					if (BoardManager1.PiecePos [k+1, h].tag == "black") {
						BoardManager1.possibleMoves [l] = pos - (o * 9);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (o * 9);
					o++;
					l++;
				}
			}


			for (int k = i - 1, h = j - 1; k > 0 && h >= 0; k--, h--) {
				if (BoardManager1.PiecePos [k+1, h] != null) {
					if (BoardManager1.PiecePos [k+1, h].tag == "black") {
						BoardManager1.possibleMoves [l] = pos - (p * 11);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (p * 11);
					p++;
					l++;
				}
			}
		} else 
		{
			for (int k = i + 1, h = j + 1; k < 8 && h < 8; k++, h++) {
				if (BoardManager1.PiecePos [k+1, h] != null) {
					if (BoardManager1.PiecePos [k+1, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos + (m * 11);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (m * 11);
					m++;
					l++;
				}
			}
			for (int k = i + 1, h = j - 1; k < 8 && h >= 0; k++, h--) {
				if (BoardManager1.PiecePos [k+1, h] != null) {
					if (BoardManager1.PiecePos [k+1, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos + (n * 9);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (n * 9);
					n++;
					l++;
				}
			}
			for (int k = i - 1, h = j + 1; k > 0 && h < 8; k--, h++) {
				if (BoardManager1.PiecePos [k+1, h] != null) {
					if (BoardManager1.PiecePos [k+1, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos - (o * 9);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (o * 9);
					o++;
					l++;
				}
			}
			for (int k = i - 1, h = j - 1; k > 0 && h >= 0; k--, h--) {
				if (BoardManager1.PiecePos [k+1, h] != null) {
					if (BoardManager1.PiecePos [k+1, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos - (p * 11);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (p * 11);
					p++;
					l++;
				}
			}
		}
		for (int c = 0; c < 14; c++) 
		{
			Debug.Log ("  " + BoardManager1.possibleMoves [c]);
		}
	}
}
