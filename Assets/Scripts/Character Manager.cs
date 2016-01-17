using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public static class CharacterManager {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
class PlayerSave
{
	//our level
	int level;
	//our score
	int score;
	//Our map index
	int mapIndex;
	//our character index
	int charIndex;

	//our constructor
	public PlayerSave()
	{
		level = 0;
		score = 0;
		mapIndex = 0;
		charIndex = 0;
	}

	//Set and get methods
	public void setLevel(int lvl)
	{
		level = lvl;
	}

	public int getLevel()
	{
		return level;
	}

	public void setScore(int s)
	{
		score = s;
	}

	public int getScore()
	{
		return score;
	}

	public void setMapIndex(int i)
	{
		mapIndex = i;
	}

	public int getMapIndex()
	{
		return mapIndex;
	}

	public void setCharIndex(int i)
	{
		charIndex = i;
	}

	public int getCharIndex()
	{
		return charIndex;
	}


}
