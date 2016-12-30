using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {
	public Button startText;
	public Canvas quitMenu;
	public Button exitText;
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}
	void Update()
	{
		if (Input.GetKey (KeyCode.Escape)) 
		{
			ExitPress ();
		}
	}
	
	public void startLevel()
	{
		SceneManager.LoadScene ("Scene2");
	}
	public void ExitPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		/*	if (Input.GetKey (KeyCode.Escape)) 
		{
			NoPress ();
		}*/
	}
	public void NoPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}
	public void Exitgame()
	{
		Application.Quit (); 
	}
}
