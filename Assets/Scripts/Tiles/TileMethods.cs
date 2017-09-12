using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileMethods : MonoBehaviour {

	public GameObject unitObject;

	public void AddUnits(int num){
		TileInfoHolder tileinfo = gameObject.GetComponent<TileInfoHolder>();
		for (int i = 0; i < num; i++) {
			tileinfo.villagers.Add(unitObject);
			tileinfo.villagers[i].transform.SetParent(gameObject.transform);
			Debug.Log("Added a unit to " + gameObject.name);
		}
	}

	public bool DeleteUnits(int num){
		
		TileInfoHolder tileinfo = gameObject.GetComponent<TileInfoHolder>();
		int initialunits = tileinfo.villagers.Count;

		try {
			for (int i = 0; i < num; i++) {
				GameObject unit = tileinfo.villagers[tileinfo.villagers.Count -1];
				tileinfo.villagers.RemoveAt(tileinfo.villagers.Count - 1);
				Destroy(unit);
				Debug.Log("Removed a unit from " + gameObject.name);

			}
		} catch (ArgumentOutOfRangeException) {
				Debug.Log("Attemped to remove " + (num - initialunits).ToString() + " units more than existed on " + gameObject.name);
				return false;
		}
		return true;
	}

	public void MoveUnits(GameObject fromTile){
		TileMethods selectedTileMethods = fromTile.GetComponent<TileMethods>();
		TileInfoHolder selectedTileInfo = fromTile.GetComponent<TileInfoHolder>();
		if (selectedTileInfo.neighbours.Contains(gameObject)){
			if (selectedTileMethods.DeleteUnits(1)) {
				AddUnits(1);
			}
		}

	}

}