using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class token : MonoBehaviour {
	
	public Vector3[][] spawn = new Vector3[][] {
		new Vector3[]{new Vector3(-35f, 0.9f, -38f),
		new Vector3(-32f, 0.6f, -38f),
		new Vector3(-35f, 0.6f, -42f),
		new Vector3(-32f, 0.6f, -42f)},
		new Vector3[]{new Vector3(9f, 0.6f, -38f),
		new Vector3(12f, 0.6f, -38f),
		new Vector3(9f, 0.6f, -42f),
		new Vector3(12f, 0.6f, -42f)},
		new Vector3[]{new Vector3(30f, 0.6f, 3f),
		new Vector3(34f, 0.6f, 3f),
		new Vector3(30f, 0.6f, -1f),
		new Vector3(34f, 0.6f, -1f)},
		new Vector3[]{new Vector3(9f, 0.6f, 40f),
		new Vector3(12f, 0.6f, 40f),
		new Vector3(9f, 0.6f, 44f),
		new Vector3(12f, 0.6f, 44f)},
		new Vector3[]{new Vector3(-31f, 0.6f, 42f),
		new Vector3(-35f, 0.6f, 42f),
		new Vector3(-31f, 0.6f, 38f),
		new Vector3(-35f, 0.6f, 38f)},
		new Vector3[]{new Vector3(-56f, 0.6f, 2f),
		new Vector3(-52f, 0.6f, 2f),
		new Vector3(-56f, 0.6f, -2f),
		new Vector3(-52f, 0.6f, -2f)}
	};			

	public int id;
	public int rol;
	// Use this for initialization
	//[rol][id]
	void Start () {
		switch ( rol ){
			case 0:
				this.transform.Find("default").GetComponent<Renderer>().material.color = Color.red;
				Debug.Log("rol0");
				break;				
			case 1:
				this.transform.Find("default").GetComponent<Renderer>().material.color = new Color(1,0.647f,0,1);
				Debug.Log("rol1");
				break;
			case 2:
				this.transform.Find("default").GetComponent<Renderer>().material.color = Color.yellow;
				Debug.Log("rol2");
				break;
			case 3:
				this.transform.Find("default").GetComponent<Renderer>().material.color = Color.green;
				Debug.Log("rol3");
				break;
			case 4:
				this.transform.Find("default").GetComponent<Renderer>().material.color = Color.blue;
				Debug.Log("rol4");
				break;
			case 5: 
				this.transform.Find("default").GetComponent<Renderer>().material.color = Color.magenta;
				Debug.Log("rol5");
				break;
		}
		this.transform.position = spawn[rol][id];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
