using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {
	public Class_GameBoard.GameBoard board;

	// Use this for initialization
	void Start () {

		JsonReader test = new JsonReader();
		board = test.LoadMap();

		Transform tiletransform = transform.Find("Tile") as Transform;
		TileMethods tile = tiletransform.gameObject.GetComponent("TileMethods") as TileMethods;
		tile.AddUnits(5);
		tile.DeleteUnits(2);
	}
	

}
