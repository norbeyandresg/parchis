using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPath : MonoBehaviour {

	public GameObject[] waypoints;
	private double[] pos;

	[SerializeField]
	private float moveSpeed = 1f;

	[HideInInspector]
	public int waypointIndex = 0;

	public int steps = 0;

	public int player = 0;

	public int tockenId = 0;

	public bool moveAllowed = false;


	// Use this for initialization
	void Start () {
		waypoints = new GameObject[156];
		for (int i = 0 ; i < 156; i++){
			waypoints[i] = GameObject.Find(""+(i+1));
		}
		if (player == 1 ){
			pos = waypoints[waypointIndex].GetComponent<cellBox>().getPos();
			transform.position = new Vector3((float)pos[0], 0.6f, (float)pos[1]) ;
		} else if (player == 2) {
			pos = waypoints[waypointIndex].GetComponent<cellBox>().getPos();
			transform.position = new Vector3((float)pos[0], 0.6f, (float)pos[1]) ;
		}

	}

	// Update is called once per frame
	void Update () {
		if (moveAllowed){
			//StartCoroutine("WaitForInstruction");
			Move();
		}
	}

	private IEnumerator WaitForInstruction() {
		while (true) {
			if(Input.GetMouseButtonDown(0) && GameControl.playerTurn == player) {
				Move();
				yield return new WaitForSeconds(1f);
				yield break;
			}
			yield return null;
		}
	}

	private void Move() {
		cellBox cell = waypoints[waypointIndex].GetComponent<cellBox>();
		pos = cell.getPos();
		if (waypointIndex == waypoints.Length-1) { waypointIndex = 0; }
		if (waypointIndex <= waypoints.Length - 1){
			transform.position = Vector3.MoveTowards(transform.position,
			new Vector3((float)pos[0], 0.6f, (float)pos[1]),
			moveSpeed * Time.deltaTime);

			if (transform.position == new Vector3((float)pos[0], 0.6f, (float)pos[1])){
				if (cell.skyId == player ){
					if (waypoints[waypointIndex+1].GetComponent<cellBox>().skyId == 0){
						waypointIndex += 0;
					} else {
						waypointIndex += 1;
					}
				} else if (cell.skyId == 0){
					waypointIndex += 1;
				} else {
					waypointIndex += 10;
				}
				steps += 1;
				pos = cell.getPos();
			}
		}
	}
}
