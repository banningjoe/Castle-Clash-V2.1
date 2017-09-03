using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInfoHolder : MonoBehaviour {

	public enum ownerset {none, team1, team2};
	public enum tiletypeset {none, castle, field, resource}

	public ownerset owner;
	public tiletypeset tiletype;
	public List<GameObject> units;
	public List<GameObject> neighbours;
}
