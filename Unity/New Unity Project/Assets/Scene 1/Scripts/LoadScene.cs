using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel(int level)
	{
		SceneManager.LoadScene(level);
	}
}
