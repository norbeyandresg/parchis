using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceController : MonoBehaviour {

	private bool coroutineAllowed = true;
	private int whosTurn = 1;
	public static int diceOneThrown = 0;
	public static int diceTwoThrown = 0;
	private DiceOne scriptOne;
	private DiceTwo scriptTwo;
	private int h = 0;

	void Start () {
		GameObject diceOne = GameObject.Find("diceOne");
	  scriptOne = diceOne.GetComponent<DiceOne>();
		GameObject diceTwo = GameObject.Find("diceTwo");
		scriptTwo = diceTwo.GetComponent<DiceTwo>();
	}

	public void setCoroutineFalse() {
		coroutineAllowed = false;
	}

	private void OnMouseDown() {
		if (!GameControl.gameOver && coroutineAllowed) {
			scriptOne.action();
			scriptTwo.action();
			
			Debug.Log(diceOneThrown + diceTwoThrown);
			GameControl.diceSideThrown = diceOneThrown + diceTwoThrown;

			if (whosTurn == 1){
				GameControl.MovePlayer(1);
			}else if (whosTurn == -1) {
				GameControl.MovePlayer(2);
			}
			whosTurn *= -1;
	    coroutineAllowed = true;
		}
	}


	// Update is called once per frame
	void Update () {}
}
