using UnityEngine;
using System.Collections;

public class queen : MonoBehaviour {
	public void moves()
	{
		int pos = BoardManager1.pos;
		int i, j, l=0,m=1,n=1,o=1,p=1;
		i = (pos / 10)-1;
		j = (pos % 10)-1;
		if (BoardManager1.player == "white") {
			for (int k = i + 1, h = j + 1; k < 8 && h < 8; k++, h++) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "black") {
						BoardManager1.possibleMoves [l] = pos + (m * 11);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (m * 11);
					m++;
					l++;
				}
			}


			for (int k = i + 1, h = j - 1; k < 8 && h >= 0; k++, h--) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "black") {
						BoardManager1.possibleMoves [l] = pos + (n * 9);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (n * 9);
					n++;
					l++;
				}
			}

			for (int k = i - 1, h = j + 1; k >= 0 && h < 8; k--, h++) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "black") {
						BoardManager1.possibleMoves [l] = pos - (o * 9);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (o * 9);
					o++;
					l++;
				}
			}


			for (int k = i - 1, h = j - 1; k >= 0 && h >= 0; k--, h--) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "black") {
						BoardManager1.possibleMoves [l] = pos - (p * 11);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (p * 11);
					p++;
					l++;
				}
			}
			m = 1;
			n = 1;
			o = 1;
			p = 1;
		}else 
		{
			for (int k = i + 1, h = j + 1; k < 8 && h < 8; k++, h++) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos + (m * 11);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (m * 11);
					m++;
					l++;
				}
			}
			for (int k = i + 1, h = j - 1; k < 8 && h >= 0; k++, h--) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos + (n * 9);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos + (n * 9);
					n++;
					l++;
				}
			}
			for (int k = i - 1, h = j + 1; k >=0 && h < 8; k--, h++) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos - (o * 9);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (o * 9);
					o++;
					l++;
				}
			}
			for (int k = i - 1, h = j - 1; k >= 0 && h >= 0; k--, h--) {
				if (BoardManager1.PiecePos [k, h] != null) {
					if (BoardManager1.PiecePos [k, h].tag == "white") {
						BoardManager1.possibleMoves [l] = pos - (p * 11);
						l++;
					}
					break;
				} else {
					BoardManager1.possibleMoves [l] = pos - (p * 11);
					p++;
					l++;
				}
			}
		}
		Debug.Log ("**************** " + BoardManager1.PiecePos[i,j] );
		for (int c = 0; c < l; c++) {
			if (c == 4)
				Debug.Log ("Possible 4 " + BoardManager1.possibleMoves [c]);
			Debug.Log (BoardManager1.possibleMoves [c]);
		}
		Debug.Log ("****************");
	}
}
