using UnityEngine;
using System.Collections;

public class king : MonoBehaviour {
	public void moves()
	{
		int pos = BoardManager1.pos;
		int i, j, l=0,m=1,n=1,o=1,p=1;
		i = (pos / 10)-1;
		j = (pos % 10)-1;
		if (BoardManager1.player == "white") {
			if ((i + 1) < 8) {
				if (BoardManager1.PiecePos [i + 1, j] != null) {
					if (BoardManager1.PiecePos [i + 1, j].transform.tag == "black") {
						BoardManager1.possibleMoves [l] = pos + 10;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos + 10;
					l++;
				}
			}
			if ((i - 1) >= 0) {
				if (BoardManager1.PiecePos [i - 1, j] != null) {
					if (BoardManager1.PiecePos [i - 1, j].transform.tag == "black") {
						BoardManager1.possibleMoves [l] = pos - 10;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos - 10;
					l++;
				}
			}
			if ((j - 1) >= 0) {
					if (BoardManager1.PiecePos [i, j - 1] != null) {
						if (BoardManager1.PiecePos [i, j - 1].transform.tag == "black") {
							BoardManager1.possibleMoves [l] = pos - 1;
							l++;
						}
					} else {
						BoardManager1.possibleMoves [l] = pos - 1;
						l++;
					}
			}
			if ((j + 1) < 8) {
				if (BoardManager1.PiecePos [i, j + 1] != null) {
					if (BoardManager1.PiecePos [i, j + 1].transform.tag == "black") {
						BoardManager1.possibleMoves [l] = pos + 1;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos + 1;
					l++;
				}
			}
			if ((i + 1) < 8 && (j + 1) < 8) {
							if (BoardManager1.PiecePos [i + 1, j + 1] != null) {
								if (BoardManager1.PiecePos [i + 1, j + 1].transform.tag == "black") {
									BoardManager1.possibleMoves [l] = pos + 11;
									l++;
								}
							} else {
								BoardManager1.possibleMoves [l] = pos + 11;
								l++;
							}
			}
			if ((i + 1) < 8 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i + 1, j - 1] != null) {
					if (BoardManager1.PiecePos [i + 1, j - 1].transform.tag == "black") {
						BoardManager1.possibleMoves [l] = pos + 9;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos + 9;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j + 1) < 8) {
				if (BoardManager1.PiecePos [i - 1, j + 1] != null) {
					if (BoardManager1.PiecePos [i - 1, j + 1].transform.tag == "black") {
						BoardManager1.possibleMoves [l] = pos - 9;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos - 9;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i - 1, j - 1] != null) {
					if (BoardManager1.PiecePos [i - 1, j - 1].transform.tag == "black") {
						BoardManager1.possibleMoves [l] = pos - 11;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos - 11;
					l++;
				}
			}
		} 
		else 
		{
			if ((i + 1) < 8) {
				if (BoardManager1.PiecePos [i + 1, j] != null) {
					if (BoardManager1.PiecePos [i + 1, j].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos + 10;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos + 10;
					l++;
				}
			}
			if ((i - 1) >= 0) {
				if (BoardManager1.PiecePos [i - 1, j] != null) {
					if (BoardManager1.PiecePos [i - 1, j].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos - 10;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos - 10;
					l++;
				}
			}
			if ((j - 1) >= 0) {
				if (BoardManager1.PiecePos [i, j - 1] != null) {
					if (BoardManager1.PiecePos [i, j - 1].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos - 1;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos - 1;
					l++;
				}
			}
			if ((j + 1) < 8) {
				if (BoardManager1.PiecePos [i, j + 1] != null) {
					if (BoardManager1.PiecePos [i, j + 1].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos + 1;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos + 1;
					l++;
				}
			}
			if ((i + 1) < 8 && (j + 1) < 8) {
				if (BoardManager1.PiecePos [i + 1, j + 1] != null) {
					if (BoardManager1.PiecePos [i + 1, j + 1].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos + 11;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos + 11;
					l++;
				}
			}
			if ((i + 1) < 8 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i + 1, j - 1] != null) {
					if (BoardManager1.PiecePos [i + 1, j - 1].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos + 9;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos + 9;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j + 1) < 8) {
				if (BoardManager1.PiecePos [i - 1, j + 1] != null) {
					if (BoardManager1.PiecePos [i - 1, j + 1].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos - 9;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos - 9;
					l++;
				}
			}
			if ((i - 1) >= 0 && (j - 1) >= 0) {
				if (BoardManager1.PiecePos [i - 1, j - 1] != null) {
					if (BoardManager1.PiecePos [i - 1, j - 1].transform.tag == "white") {
						BoardManager1.possibleMoves [l] = pos - 11;
						l++;
					}
				} else {
					BoardManager1.possibleMoves [l] = pos - 11;
					l++;
				}
			}
		}
	}
}
