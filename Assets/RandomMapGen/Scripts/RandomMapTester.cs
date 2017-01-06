using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapTester : MonoBehaviour {

	[Header("Map Dimensions")]
	public int mapWidth = 20;
	public int mapHeight = 20;

	public Map map; 

	// Use this for initialization
	void Start () {
		map = new Map ();
		
	}
	
	public void MakeMap() {
		map.NewMap (mapWidth, mapHeight);
		Debug.Log ("Created a new map: " + map.columns + " x " + map.rows + " map");
	}
}
