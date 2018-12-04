using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initPlayers : MonoBehaviour {

	private GameObject PlayerScript;
	public Transform spawnPos;
	public GameObject RED;
	public GameObject ORANGE;
	public GameObject YELLOW;
	public GameObject GREEN;
	public GameObject BLUE;
	public GameObject PURPLE;


	public Vector3[] spawnRed = {
		new Vector3(-35f, 0.9f, -38f),
		new Vector3(-32f, 0.6f, -38f),
		new Vector3(-35f, 0.6f, -42f),
		new Vector3(-32f, 0.6f, -42f),
	};

	public Vector3[] spawnOrange = {
		new Vector3(9f, 0.6f, -38f),
		new Vector3(12f, 0.6f, -38f),
		new Vector3(9f, 0.6f, -42f),
		new Vector3(12f, 0.6f, -42f),
	};

	public Vector3[] spawnYellow = {
		new Vector3(30f, 0.6f, 3f),
		new Vector3(34f, 0.6f, 3f),
		new Vector3(30f, 0.6f, -1f),
		new Vector3(34f, 0.6f, -1f),
	};

	public Vector3[] spawnGreen = {
		new Vector3(9f, 0.6f, 40f),
		new Vector3(12f, 0.6f, 40f),
		new Vector3(9f, 0.6f, 40f),
		new Vector3(12f, 0.6f, 40f),
	};

	public Vector3[] spawnBlue = {
		new Vector3(-35f, 0.6f, 42f),
		new Vector3(-39f, 0.6f, 42f),
		new Vector3(-35f, 0.6f, 38f),
		new Vector3(-39f, 0.6f, 38f),
	};

	public Vector3[] spawnPurple = {
		new Vector3(-56f, 0.6f, 2f),
		new Vector3(-52f, 0.6f, 2f),
		new Vector3(-56f, 0.6f, -2f),
		new Vector3(-52f, 0.6f, -2f),
	};

	// Use this for initialization
	void Start () {
		GameObject pRed1 = (GameObject)Instantiate(RED, spawnRed[0], Quaternion.Euler(0,0,0));
		GameObject pRed2 =(GameObject)Instantiate(RED, spawnRed[1], Quaternion.Euler(0,0,0));
		GameObject pRed3 =(GameObject)Instantiate(RED, spawnRed[2], Quaternion.Euler(0,0,0));


		GameObject pOrange1 =(GameObject)Instantiate(ORANGE, spawnOrange[0], Quaternion.Euler(0,0,0));
		GameObject pOrange2 =(GameObject)Instantiate(ORANGE, spawnOrange[1], Quaternion.Euler(0,0,0));
		GameObject pOrange3 =(GameObject)Instantiate(ORANGE, spawnOrange[2], Quaternion.Euler(0,0,0));
		GameObject pOrange4 =(GameObject)Instantiate(ORANGE, spawnOrange[3], Quaternion.Euler(0,0,0));



		GameObject pYellow1 =(GameObject)Instantiate(YELLOW, spawnYellow[0], Quaternion.Euler(0,0,0));
		GameObject pYellow2 =(GameObject)Instantiate(YELLOW, spawnYellow[1], Quaternion.Euler(0,0,0));
		GameObject pYellow3 =(GameObject)Instantiate(YELLOW, spawnYellow[2], Quaternion.Euler(0,0,0));
		GameObject pYellow4 =(GameObject)Instantiate(YELLOW, spawnYellow[3], Quaternion.Euler(0,0,0));


		GameObject pGreen1 =(GameObject)Instantiate(GREEN, spawnGreen[0], Quaternion.Euler(0,0,0));
		GameObject pGreen2 =(GameObject)Instantiate(GREEN, spawnGreen[1], Quaternion.Euler(0,0,0));
		GameObject pGreen3 =(GameObject)Instantiate(GREEN, spawnGreen[2], Quaternion.Euler(0,0,0));
		GameObject pGreen4 =(GameObject)Instantiate(GREEN, spawnGreen[3], Quaternion.Euler(0,0,0));



		GameObject pBlue1 =(GameObject)Instantiate(BLUE, spawnBlue[0], Quaternion.Euler(0,0,0));
		GameObject pBlue2 =(GameObject)Instantiate(BLUE, spawnBlue[1], Quaternion.Euler(0,0,0));
		GameObject pBlue3 =(GameObject)Instantiate(BLUE, spawnBlue[2], Quaternion.Euler(0,0,0));


		GameObject pPurple1 =(GameObject)Instantiate(PURPLE, spawnPurple[0], Quaternion.Euler(0,0,0));
		GameObject pPurple2 =(GameObject)Instantiate(PURPLE, spawnPurple[1], Quaternion.Euler(0,0,0));
		GameObject pPurple3 =(GameObject)Instantiate(PURPLE, spawnPurple[2], Quaternion.Euler(0,0,0));
		GameObject pPurple4 =(GameObject)Instantiate(PURPLE, spawnPurple[3], Quaternion.Euler(0,0,0));

	}

	// Update is called once per frame
	void Update () {

	}
}
	
