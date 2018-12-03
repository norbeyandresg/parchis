using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTwo : MonoBehaviour {

	public Sprite[] diceSides;
  private SpriteRenderer rend;

	// Use this for initialization
	void Start () {
    rend = GetComponent<SpriteRenderer>();
    rend.sprite = diceSides[5];
	}

	public void action(){
		StartCoroutine("RollTheDice");
	}

  private IEnumerator RollTheDice() {
    int randomDiceSide = 0;
    for (int i = 0; i <= 20; i++) {
      randomDiceSide = Random.Range(0, 6);
      rend.sprite = diceSides[randomDiceSide];
      yield return new WaitForSeconds(0.05f);
    }

    diceController.diceTwoThrown = randomDiceSide + 1;
  }

	// Update is called once per frame
	void Update () {

	}
}
