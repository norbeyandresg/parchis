using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int ID = 0;
	public GameObject[] gameTokens = new GameObject[4];

	public Player(int _ID, GameObject[] _gameTokens) {
		ID = _ID;
		gameTokens = _gameTokens;
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
