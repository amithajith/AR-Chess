using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class sceneExit : MonoBehaviour {
	void Update()
	{
		if (Application.platform == RuntimePlatform.Android) 
		{
			if (Input.GetKey (KeyCode.Escape)) 
			{
				SceneManager.LoadScene ("Scene1");
			}
		}
		if (Input.GetKey (KeyCode.Escape)) 
		{
			SceneManager.LoadScene ("Scene1");
		}
	}
}
