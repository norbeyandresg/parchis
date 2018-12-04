using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	//red,orange,yellow,green,blue,purple
	//public GameObject prefabToken;
	public int rol;
	public int turn;		
	public List<GameObject> tokens;
	public int numFichas;
	
	/*public Player(int r, int t, int n){
		rol=r;
		turn=t;
		numFichas=n;
	}*/

	// Use this for initialization
	void Start () {
		tokens=new List<GameObject>();
		for(int i=0;i<numFichas;i++){
			GameObject.Find("Main Camera").GetComponent<GameMaster>().prefabToken.GetComponent<token>().id=i;
			GameObject.Find("Main Camera").GetComponent<GameMaster>().prefabToken.GetComponent<token>().rol=rol;
			GameObject tmp=Instantiate(GameObject.Find("Main Camera").GetComponent<GameMaster>().prefabToken) as GameObject;						
			tokens.Add(tmp);
		}		
	}

	// Update is called once per frame
	void Update () {

	}
}
