using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceOne : MonoBehaviour {

	public Sprite[] diceSides;
  private SpriteRenderer rend;
	private diceController diceController;

	// Use this for initialization
	void Start () {
		GameObject controller = GameObject.Find("dice");
		diceController = controller.GetComponent<diceController>();
    rend = GetComponent<SpriteRenderer>();
    rend.sprite = diceSides[5];
	}

	public void action(){
		StartCoroutine("RollTheDice");
	}

  private IEnumerator RollTheDice() {
		diceController.setCoroutineFalse();
    int randomDiceSide = 0;
    for (int i = 0; i <= 20; i++) {
      randomDiceSide = Random.Range(0, 6);
      rend.sprite = diceSides[randomDiceSide];
      yield return new WaitForSeconds(0.05f);
    }

    diceController.diceOneThrown = randomDiceSide + 1;
  }

	// Update is called once per frame
	void Update () {

	}
}
