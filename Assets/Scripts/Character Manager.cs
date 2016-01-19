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
class PlayerChar
{
	
	//General Character Attributes
	//Our Character name
	private string name;
	//Our Character Gender
	private string gender;
	//Our character class
	private string className;
	//Our Character Model
	private SpriteRenderer sprite;


	//Our current Money
	private int money;
	//Our arraylist of items
	private ArrayList items = new ArrayList();
	//Our arraylist of equipment
	private ArrayList equip = new ArrayList();

	//Our Current Equipped Items
	//Head
	private GameItem head;
	//Torso
	private GameItem torso;
	//Legs
	private GameItem pants;
	//Shoes
	private GameItem feet;
	//Weapon
	private GameItem weapon;

	//Our Character Stats
	//Health
	private int hp;
	//Strength
	private int strength;
	//Intelligence
	private int intelligence;
	//Dexterity
	private int dexterity;

	//Levling
	//Character Level
	private int charLevel;
	//Experience Points
	private int exp;
	//Available Skill Points
	private int skillPoints;


	//Game Stats
	//Battle Wins
	private int battleWins;
	//Battle Losses
	private int battleLosses;
	//Game Score
	//TODO: Make a function that calculates Score

	//our constructor
	public PlayerChar(string charName, string charGender, string charClass, SpriteRenderer charSprite)
	{
		//First set our input variables
		name = charName;
		gender = charGender;
		className = charClass;
		sprite = charSprite;

		//Set money to 25 guaps
		money = 25;
		//Give the player a water
		items.Add(GameManager.gameItems[0]);
		//Dont Give the character any equipment

		//Give the player baby equipment
		head = GameManager.headEquip[0];
		torso = GameManager.torsoEquip [0];
		pants = GameManager.legEquip [0];
		feet = GameManager.feetEquip [0];
		weapon = GameManager.weaponEquip [0];

		//Set the character leveling
		charLevel = 1;
		exp = 0;
		skillPoints = 5;

		//Set game stats
		battleWins = 0;
		battleLosses = 0;
	}

}
