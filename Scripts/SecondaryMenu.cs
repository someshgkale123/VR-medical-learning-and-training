using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondaryMenu : MonoBehaviour {

	public void SecondGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 2);
	}
}
