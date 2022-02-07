using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	[SerializeField] GameObject[] levelObjects;
	[SerializeField] AudioSource[] audioSources;
	int levelNum;

	void Start()
	{
		levelNum = 1;
		ShowAllLevels();
	}

	void Update()
    {
		for (int i = 0; i < audioSources.Length; i++)
        {
			if (audioSources[i].volume > 0.0f && i+1 != levelNum)
            {
				audioSources[i].volume = 0.0f;
            }
			else if (audioSources[i].volume != 0.8f && i+1 == levelNum)
            {
				audioSources[i].volume = 0.8f;
            }
        }
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
