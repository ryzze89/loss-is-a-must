using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	[SerializeField] GameObject[] levelObjects;
	int levelNum;

	void Start()
	{
		levelNum = 1;
		ShowAllLevels();
	}

	public void SwitchLevel(int number)
	{
		levelNum = number;
		foreach(GameObject lvl in levelObjects)
		{
			lvl.SetActive(false);
		}
		levelObjects[levelNum-1].SetActive(true);
	}

	public void ShowAllLevels()
	{
		foreach(GameObject lvl in levelObjects)
		{
			lvl.SetActive(true);
		}
	}
}
