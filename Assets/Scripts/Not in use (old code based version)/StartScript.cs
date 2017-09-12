using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {
	public Class_GameBoard.GameBoard board;
	public GameObject tile0;
	// Use this for initialization
	void Start () {

		JsonReader test = new JsonReader();
		board = test.LoadMap();
		CreateGameObject(board.grid[0]);



//		Transform tiletransform = transform.Find("Tile") as Transform;
//		TileMethods tile = tiletransform.gameObject.GetComponent("TileMethods") as TileMethods;
//		tile.AddUnits(5);
//		tile.DeleteUnits(2);
	}

	public void CreateGameObject(Class_BoardSquare.BoardSquare tile){
		// Serialization does not exist for unity specific types (vector3, quaternion, so we 
		// deserialize as ints, and then convert to vectors and then finally quaternions)
			Vector3 location = new Vector3(tile.int_location[0],tile.int_location[1],tile.int_location[2]);
			Vector3 vector_rotation = new Vector3(tile.int_rotation[0],tile.int_rotation[1],tile.int_rotation[2]);
			Quaternion rotation = Quaternion.Euler(vector_rotation);
		//The above three lines are just conversions
			GameObject self = Instantiate(tile0, location , rotation, gameObject.transform);
			self.name = tile.name;
			TileMethods tileMethods = self.GetComponent<TileMethods>();

    	}
	

}
