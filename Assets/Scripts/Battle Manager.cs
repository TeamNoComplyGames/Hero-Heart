using UnityEngine;
using System; //Allows us to catch exception
using System.Collections;

public class BattleManager: MonoBehaviour {

	//Boolean to determine if the game has begun
	private bool started;

	//Boolean to determine if the game is over
	private bool gameOver;

	//Our Text
	public GameObject[] battleText;

	//Our Buttons
	public GameObject[] fightButton;
	public GameObject[] specialButton;
	public GameObject[] itemsButton;
	public GameObject[] runButton;

	//Our background music
	private AudioSource bgFight;
	private AudioSource bgBoss;

	//Our Sounds

	//TODO: Get our character Save Manager to get stats and things


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
