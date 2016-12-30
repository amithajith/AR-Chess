using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using System.Linq;

public class BoardManager1 : MonoBehaviour {

	public Camera cameraLeft;
	public GameObject pointer;
	public GameObject RadialProgressBar;
	public Transform LoadingBar;
	public Transform TextIndicator;
	[SerializeField] private float currentAmount = 0;
	[SerializeField] private float speed;
	private GameObject selectedPiece=null;
	public GameObject prevObj=null;
	public Material blackboard, whiteboard;
	//public Material white;
	public Collider hitTemp;
	public bool hit;
	public RaycastHit hitInfo;
	public List<GameObject> Board;
	public static GameObject[,] PiecePos = new GameObject[8, 8];
	public bool pieceSelected = false;
	public int index = 0;
	public int l,m;
	public static bool firstMove = true;
	public static int pos,prevpos;
	Vector3 temp;
	Transform tr;
	string[] str = new string[14];
	string str1,str2,str3;
	public static string player = "white";
	public static int[] possibleMoves = new int[14] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};
	public GameObject grn;

	void Start()
	{
		
		for (int i = 0; i < 2; i++) 
		{
			for (int j = 0; j < 8; j++) 
			{
				PiecePos [i, j] = Board[index];
			//	Debug.Log (PiecePos [i, j].transform.name + i + j);
				index++;
			}
		}
		for (int i = 6; i < 8; i++) 
		{
			for (int j = 0; j < 8; j++) 
			{
				PiecePos [i, j] = Board[index];
			//	Debug.Log (PiecePos [i, j].transform.name + i + j);
				index++;
			}
		}
	}

	void Update()
	{
		if (pieceSelected == false) {
			pieceSelection ();
		} else 
		{
			pieceSelection ();
		}
	}

	public void pieceSelection()
	{
		Ray ray = cameraLeft.ScreenPointToRay (RadialProgressBar.transform.position);
		hitTemp = hitInfo.collider;
		hit = Physics.Raycast (ray, out hitInfo);

				if (hitTemp != null || hitInfo.collider != null) 
				{
					if (hitTemp == hitInfo.collider && (hitInfo.collider.tag == "blackboard" || hitInfo.collider.tag == "whiteboard")) {
						selectedPiece = hitInfo.collider.gameObject;
				int e = ((Int32.Parse (selectedPiece.transform.name)) / 10)-1;
				int w = ((Int32.Parse (selectedPiece.transform.name)) % 10)-1;
						if (currentAmount < 100) 
						{
							if (pieceSelected == false) {
						if (PiecePos [e, w] != null && PiecePos [e, w].transform.tag == player) 
						{							
							currentAmount += speed * Time.deltaTime;
							TextIndicator.GetComponent<Text> ().text = ((int)currentAmount).ToString () + "%";
						}
							} 
							else 
							{
						if (Int32.Parse (hitInfo.collider.name) == possibleMoves [0] || Int32.Parse (hitInfo.collider.name) == possibleMoves [1] || Int32.Parse (hitInfo.collider.name) == possibleMoves [2] || Int32.Parse (hitInfo.collider.name) == possibleMoves [3] || Int32.Parse (hitInfo.collider.name) == possibleMoves [4] || Int32.Parse (hitInfo.collider.name) == possibleMoves [5] || Int32.Parse (hitInfo.collider.name) == possibleMoves [6] || Int32.Parse (hitInfo.collider.name) == possibleMoves [7]) {
									currentAmount += speed * Time.deltaTime;
									TextIndicator.GetComponent<Text> ().text = ((int)currentAmount).ToString () + "%";
									}
							}
						} 
						else 
						{
							
							TextIndicator.GetComponent<Text> ().text = "100%";
							if (selectedPiece != prevObj) 
							{
								if (prevObj != null) 
								{
									if (prevObj.tag == "blackboard") {
										prevObj.GetComponent<Renderer> ().material.color = blackboard.color;
									} else if (prevObj.tag == "whiteboard") {
										prevObj.GetComponent<Renderer> ().material.color = whiteboard.color;
									}
							for (int c = 0; c < 14; c++) 
							{
								str [c] = possibleMoves [c].ToString ();
								if (possibleMoves [c] > 0) 
								{
									if (GameObject.Find (str [c]).tag == "blackboard") 
									{
										GameObject.Find (str[c]).GetComponent<Renderer> ().material.color = blackboard.color;
									}
									else if (GameObject.Find (str [c]).tag == "whiteboard")
									{
										GameObject.Find (str[c]).GetComponent<Renderer> ().material.color = whiteboard.color;
									}											
								}

							}
								}
								if (selectedPiece.transform.name != "Table") {
									selectedPiece.GetComponent<Renderer> ().material.color = Color.blue;
									prevObj = selectedPiece;
									pos = Int32.Parse (selectedPiece.transform.name);
									int i = (pos / 10)-1;
									int j = (pos % 10)-1;

									if (pieceSelected == false) 
									{
										if (PiecePos [i, j] != null) 
										{
											string type = PiecePos [i, j].transform.GetChild (0).tag;
									switch (type) {
										case "pawn":
										pawn p = gameObject.AddComponent <pawn> ()as pawn;
										p.moves ();
										break;

									case "knight":
										knight kn = gameObject.AddComponent <knight> ()as knight;
										kn.moves ();
										break;

									case "rook":
										rook r = gameObject.AddComponent<rook> ()as rook;
										r.moves ();
										break;

									case "king":
										king k = gameObject.AddComponent<king> ()as king;
										k.moves ();
										break;

									case "queen":
										queen q = gameObject.AddComponent<queen> ()as queen;
										q.moves ();
										break;

									case "bishop":
										bishop b = gameObject.AddComponent<bishop> ()as bishop;
										b.moves ();
										break;
									}
									for (int c = 0; c < 14; c++) 
									{
										str [c] = possibleMoves [c].ToString ();
										if (possibleMoves [c] > 0) 
										{
											GameObject.Find (str[c]).GetComponent<Renderer> ().material.color = Color.green;
										}

									}
											if (PiecePos [i, j].transform.tag == player) 
											{
												pieceSelected = true;
												prevpos = pos;
												l = i;
												m = j;
											} 	
										}
									} 
									else 
									{
										
										tr = selectedPiece.transform;
										//tr.transform.parent = GameObject.Find ("chess_board").transform;
										//Vector3 posi = tr.transform.position;
										//PiecePos [l, m].transform.position = new Vector3 (posi.x, posi.y + 2.5f , posi.z - 6f);
										PiecePos [l, m].transform.position = tr.transform.position;
										PiecePos [i, j] = PiecePos [l, m];
										PiecePos [l, m] = null;
								Debug.Log ("New position = " + i + " & " + j);
										pieceSelected = false;
										if (player == "white") {
											player = "black";
										} else {
											player = "white";
										}
								for (int z = 0; z < 14; z++) 
								{
									possibleMoves [z] = -1;
								}
									}
								}
							}

						}
						LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
					}
					if (hitTemp != hitInfo.collider) {
						currentAmount = 0;
						LoadingBar.GetComponent<Image> ().fillAmount = 0;
						TextIndicator.GetComponent<Text> ().text = "0%";
					}
				}
			}
}
