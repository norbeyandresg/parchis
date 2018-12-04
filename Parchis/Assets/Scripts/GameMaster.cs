using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	public int turn;
    public List<int> order_turn;
    public int myTurn;
    public List<GameObject> players;  
    public GameObject prefabToken;      
    //roll order
    //red,orange,yellow,green,blue,purple
    //campesinos,empresas,indigenas,ambientales,afro,publica
    //0,1,2,3,4,5	

	// Use this for initialization
	void Start () {		
        //recover information from cache ready to play
        for(int i=0;i<6;i++){
            GameObject tmp=new GameObject();
            tmp.AddComponent<Player>();
            tmp.GetComponent<Player>().turn=i;
            tmp.GetComponent<Player>().rol=i;
            tmp.GetComponent<Player>().numFichas=4;
            players.Add(tmp);
            order_turn.Add(i);
        }
        myTurn=0;
	}

	// Update is called once per frame
	void Update () {

	}
}
	
