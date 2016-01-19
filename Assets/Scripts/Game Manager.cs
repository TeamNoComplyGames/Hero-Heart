using UnityEngine;
using System; //Allows us to catch exception
using System.Collections;

//This is used as a single location to store all of our strings,
//Enemy levels, and various things within the game in a single place
//For much easier management and translations in the future

public static class GameManager {

	//Array for enemy names
	public static String[] enemyName = {"Neighborly Ghost", "Speyeder", "Death Flower", "Composite",
		"Gligan The Sharp", "Cracked Skull",  "Legs The Clown", "Goblin Scavenger",  "Lizaroni", "Dark Wizard"};

	//Array for Monster Sayings
	public static String[] enemyTalk = {""};

	//Array for enemy levels per level
	public static int[] enemyLevels = {1, 1, 2, 2, 4, 4, 5, 6, 7, 9};

	//Array for damage sayings
	public static String[] damageSaying = {"BANG", "BINK", "BOP", "SLASH", 
		"BOOM", "KAPOW", "BLAM", "CLANG", "SMASH", "WHAM", "CRASH", 
		"CRACK", "BODIED", "OOOF", "SMACK", "CLINK", "SLAP", "THUD",
		"THUMP", "THWACK", "ZING", "ZAP", "SQUISH", "CLANK"};

	//Static Array for storing purchasable items
	public static GameItem[] gameItems = {
		new GameItem ("Water", "Water (Item) heals 4 HP during battle!", 50, 
			new CharRequire(), 4),
		
		new GameItem ("Tea", "Tea (Item) heals 10 HP during battle!", 100, 
			new CharRequire(), 10)
	};


	//Static Array for storing game equipment
	//Hats
	public static GameItem[] headEquip = {

		//General
		new GameItem ("Baby Hat", "Did you hack to show this? Thats kinda cool...", 100, 
			new CharRequire(), 1),

		//Rouges
		new GameItem ("Red Bandanna", "Red Bandanna (Head) adds 3 Dexterity to your total stats!", 175, 
			new CharRequire(0, 0, 0, 15), 0, 0, 0, 3),
		
		new GameItem ("Blue Bandanna", "Blue Bandanna (Head) adds 6 Dexterity to your total stats!", 275, 
			new CharRequire(0, 0, 0, 25), 0, 0, 0, 6)
	};

	//Torso
	public static GameItem[] torsoEquip = {

		//General
		new GameItem ("Baby Shirt", "Did you hack to show this? Thats kinda cool...", 100, 
			new CharRequire (), 1),


		//Tanks
		new GameItem ("Plastic Chest", "Plastic Chest (Torso) adds 3 HP to your total stats!", 175, 
			new CharRequire (15), 3),

		new GameItem ("Wooden Chest", "Wooden Chest (Torso) adds 6 HP to your total stats!", 275, 
			new CharRequire (25), 6)
	};


	//Legs
	public static GameItem[] legEquip = {

		//General
		new GameItem ("Baby Pants", "Did you hack to show this? Thats kinda cool...", 100, 
			new CharRequire (), 1)
	};

	//Feet
	public static GameItem[] feetEquip = {

		//General
		new GameItem ("Baby Shoes", "Did you hack to show this? Thats kinda cool...", 100, 
			new CharRequire (), 1)
	};


	//Weapons
	public static GameItem[] weaponEquip = {

		//General
		new GameItem ("Baby Stick", "Did you hack to show this? Thats kinda cool...", 100, 
			new CharRequire (), 0, 1),

		//Warriors
		new GameItem ("Durable Sword", "Durable Sword (Weapon) adds 3 Strength to your total stats!", 175, 
			new CharRequire (0, 15), 0, 3),

		new GameItem ("Strong Lance", "Strong Lance (Weapon) adds 6 Strength to your total stats!", 275, 
			new CharRequire (0, 25), 0, 6),


		//Mages
		new GameItem ("Water Slash Book", "Water Slash (Weapon) is a spell with a base damage of 2!", 175, 
			new CharRequire (0, 0, 15), 0),

		new GameItem ("Good Wand", "Good Wand (Weapon) gives you the spell Minor Healing, and adds 3 to your Strength!", 275, 
			new CharRequire (0, 0, 25), 0, 0, 3),
	};



}

//Class for storing requirements on an item or equipment
public class CharRequire {

	//Our stats
	private int hpReq;
	private int strengthReq;
	private int intelligenceReq;
	private int dexterityReq;

	//Contructors, shall be overloaded similar to usable items
	public CharRequire() {

		//Simply overload
		CharRequire(0, 0, 0, 0);
	}

	public CharRequire(int hp) {

		//Simply overload
		CharRequire(hp, 0, 0, 0);
	}

	public CharRequire(int hp, int strength) {

		//Simply overload
		CharRequire(hp, strength, 0, 0);
	}

	public CharRequire(int hp, int strength, int intelligence) {

		//Simply overload
		CharRequire(hp, strength, intelligence, 0);
	}

	public CharRequire(int hp, int strength, int intelligence, int dexterity) {

		//Assign Our stats to our variables
		hpReq = hp;
		strengthReq = strength;
		intelligenceReq = intelligence;
		dexterityReq = dexterity;
	}

	//Function to return if the item can be purchased
	public bool canPurchase(int hp, int strength, int intelligence, int dexterity){

		//Simply check if all the passed variables are greater than the requirements
		if (hp >= hpReq &&
		    strength >= strengthReq &&
		    intelligence >= intelligenceReq &&
		    dexterity >= dexterityReq) {
			return true;
		} else
			return false;
	}
}


//Class for creating Game Items
public class GameItem {

	//Our Items
	private String name;
	private String shopText;
	private int shopCost;
	private CharRequire requirements;

	//Their Stat Changes
	private int hpUp;
	private int strengthUp;
	private int intelligenceUp;
	private int dexterityUp;



	//Constructors, Overloading them based on their requirements
	public GameItem(String itemName, String text, int cost, CharRequire required) {

		//simply overload
		GameItem(itemName, text, cost, required, 0, 0, 0, 0);
	}

	public GameItem(String itemName, String text, int cost, CharRequire required, int hp) {

		//simply overload
		GameItem(itemName, text, cost, required, hp, 0, 0, 0);
	}

	public GameItem(String itemName, String text, int cost, CharRequire required, int hp, int strength) {

		//simply overload
		GameItem(itemName, text, cost, required, hp, strength, 0, 0);
	}

	public GameItem(String itemName, String text, int cost, CharRequire required, int hp, int strength, int intelligence) {

		//simply overload
		GameItem(itemName, text, cost, required, hp, strength, intelligence, 0);
	}

	//Final Constructor, set our variables here
	public GameItem(String itemName, String text, int cost, CharRequire required, int hp, int strength, int intelligence, int dexterity) {

		//Set the item info
		name = itemName;
		shopText = text;
		shopCost = cost;

		//Set our requirements
		requirements = required;

		//Set the stat boosters
		hpUp = hp;
		strengthUp = strength;
		intelligenceUp = intelligence;
		dexterityUp = dexterity;
	}

	//Return our item requirements
	public CharRequire getRequirements() {
		return requirements;
	}


	//use an item, insert the characters current stats, and returns an array of upgraded stats
	public int[] useItem(int hp, int strength, int intelligence, int dexterity) {

		//Add the variables to the item properties
		hp = hp + hpUp;
		strength = strength + strengthUp;
		intelligence = intelligence + intelligenceUp;
		dexterity = dexterity + dexterityUp;

		//Return the variables
		int[] itemStats = {hp, strength, intelligence, dexterity};
		return itemStats;
	}

}

//Class for creating Game Equipment
//Going to use game item, as they basically do the same thing,
//However items are a one time use
