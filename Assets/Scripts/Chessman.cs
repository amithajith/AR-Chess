using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

public abstract class Chessman : MonoBehaviour {

	public int CurX;
	public int CurY;
	public bool isWhite;
	public string position="00";
	public float max=1000;
	public int pos;
	void Update()
	{
		Updateposition ();
	}
	void Updateposition()
	{
	}
	void OnTriggerEnter(Collider other)
	{
		
		position = other.gameObject.name;

	}
}
