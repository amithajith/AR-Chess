﻿using UnityEngine;
using System.Collections;

public class dontDestroy : MonoBehaviour {

	void Awake()
	{
		GameObject[] obj = GameObject.FindGameObjectsWithTag ("music");
		if (obj.Length > 1)
			Destroy (this.gameObject);
		DontDestroyOnLoad (this.gameObject);
	}
}
