using UnityEngine;
using System; //Allows us to catch exception
using System.Collections;

public class BattleManager: MonoBehaviour {

	//Boolean to determine if the game has begun
	private bool started;

	//Boolean to determine if the game is over
	private bool gameOver;

    //Our Text
    private UnityEngine.UI.Text battleText;

    //Our Buttons
    private UnityEngine.UI.Button fightButton;
    private UnityEngine.UI.Button specialButton;
    private UnityEngine.UI.Button itemsButton;
    private UnityEngine.UI.Button runButton;

	//Our background music
	private AudioSource bgFight;
	private AudioSource bgBoss;

	//Our Sounds

	//Get our Character Manager and our character stats
	CharacterManager player = new CharacterManager();
	int playerHp;
	int playerStrength;
	int playerIntelligence;
	int playerDexterity;


	// Use this for initialization
	void Start () {

		//Things To Do:
		//Get the player character
		//find else what to do from the oncreate function on the og repo

        //Get the Battle Text
        battleText = GameObject.FindGameObjectWithTag("BattleText").GetComponent<UnityEngine.UI.Text>();

        //Get the Buttons
        fightButton = GameObject.Find ("Fight Button").GetComponent<UnityEngine.UI.Button> ();
        specialButton = GameObject.Find("Special Button").GetComponent<UnityEngine.UI.Button>();
        itemsButton = GameObject.Find("Items Button").GetComponent<UnityEngine.UI.Button>();
        runButton = GameObject.Find("Run Button").GetComponent<UnityEngine.UI.Button>();

		//Use a service or pass Params with Scene Call
		//To set the world index, and grab the story text
		//For now we will use 0
		battleText.text = GameManager.enemyTalk[0];

    }
	
	// Update is called once per frame
	/*
	void Update () {
	
	}
	*/
}
