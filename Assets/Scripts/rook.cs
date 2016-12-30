using UnityEngine;
using System.Collections;

public class rook : MonoBehaviour {
	public void moves()
	{
		int pos = BoardManager1.pos;
		int i, j, l=0,m=1,n=1,o=1,p=1;
		i = (pos / 10)-1;
		j = pos % 10;
		if (BoardManager1.player == "white") {
			for (int k = i + 1; k < 8; k++) {
				if (BoardManager1.PiecePos [k, j] != null) {
					if (BoardManager1.PiecePos [k, j].tag == "black") {
						BoardManager1.possibleMoves [l] = pos + (m * 10);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (m * 10);
					m++;
					l++;
				}
			}
			for (int a = i - 1; a > 0; a--) {
				if (BoardManager1.PiecePos [a, j] != null) {
					if (BoardManager1.PiecePos [a, j].tag == "black") {
						BoardManager1.possibleMoves [l] = pos - (o * 10);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (o * 10);
					o++;
					l++;
				}
			}
			for (int b = j + 1; b < 8; b++) {
				if (BoardManager1.PiecePos [i, b] != null) {
					if (BoardManager1.PiecePos [i, b].tag == "black") {
						BoardManager1.possibleMoves [l] = pos + n;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + n;
					n++;
					l++;
				}
			}
			for (int b = j - 1; b >= 0; b--) {
				if (BoardManager1.PiecePos [i, b] != null) {
					if (BoardManager1.PiecePos [i, b].tag == "black") {
						BoardManager1.possibleMoves [l] = pos - p;
					} 
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - p;
					p++;
					l++;
				}
			}
		} else 
		{
			for (int k = i + 1; k < 8; k++) {
				if (BoardManager1.PiecePos [k, j] != null) {
					if (BoardManager1.PiecePos [k, j].tag == "white") {
						BoardManager1.possibleMoves [l] = pos + (m * 10);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (m * 10);
					m++;
					l++;
				}
			}
			for (int a = i - 1; a > 0; a--) {
				if (BoardManager1.PiecePos [a, j] != null) {
					if (BoardManager1.PiecePos [a, j].tag == "white") {
						BoardManager1.possibleMoves [l] = pos - (n * 10);
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (n * 10);
					n++;
					l++;
				}
			}
			for (int b = j + 1; b < 8; b++) {
				if (BoardManager1.PiecePos [i, b] != null) {
					if (BoardManager1.PiecePos [i, b].tag == "white") {
						BoardManager1.possibleMoves [l] = pos + o;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + o;
					o++;
					l++;
				}
			}
			for (int b = j - 1; b >= 0; b--) {
				if (BoardManager1.PiecePos [i, b] != null) {
					if (BoardManager1.PiecePos [i, b].tag == "white") {
						BoardManager1.possibleMoves [l] = pos - p;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - p;
					p++;
					l++;
				}
			}
			
		}

	}
}
