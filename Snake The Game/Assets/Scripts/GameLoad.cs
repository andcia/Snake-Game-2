﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{

	public void loadLevel(string level)
	{
		SceneManager.LoadScene(level);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}