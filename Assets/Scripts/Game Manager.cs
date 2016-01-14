using UnityEngine;
using System; //Allows us to catch exception
using System.Collections;

//This is used as a single location to store all of our strings,
//Enemy levels, and various things within the game in a single place
//For much easier management and translations in the future

public static class GameManager {

	//Array for enemy names
	private static String[] enemyName = {"Neighborly Ghost", "Speyeder", "Death Flower", "Composite",
		"Gligan The Sharp", "Cracked Skull",  "Legs The Clown", "Goblin Scavenger",  "Lizaroni", "Dark Wizard", };

	//Array for Monster Sayings
	private static String[] enemyTalk = {""};

	//Array for enemy levels per level
	private static int[] enemyLevels = {1, 1, 2, 2, 4, 4, 5, 6, 7, 9};

	//Array for damage sayings
	private static String[] damageSaying = {"BANG", "BINK", "BOP", "SLASH", 
		"BOOM", "KAPOW", "BLAM", "CLANG", "SMASH", "WHAM", "CRASH", 
		"CRACK", "BODIED", "OOOF", "SMACK", "CLINK", "SLAP", "THUD",
		"THUMP", "THWACK", "ZING", "ZAP", "SQUISH", "CLANK"};

}
