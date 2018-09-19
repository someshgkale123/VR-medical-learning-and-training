using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level01 : MonoBehaviour {
	public void level()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
	}
}
