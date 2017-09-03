using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileMethods : MonoBehaviour {

	public GameObject unitobject;

	public void AddUnits(int num){
		TileInfoHolder tileinfo = gameObject.GetComponent("TileInfoHolder") as TileInfoHolder;
		for (int i = 0; i < num; i++) {
			tileinfo.units.Add(Instantiate(unitobject, new Vector3(i*5,0,0) , Quaternion.identity));
			tileinfo.units[i].transform.SetParent(gameObject.transform);
			Debug.Log("Added a unit to " + gameObject.name);
		}
	}

	public void DeleteUnits(int num){
		
		TileInfoHolder tileinfo = gameObject.GetComponent("TileInfoHolder") as TileInfoHolder;
		int initialunits = tileinfo.units.Count;

		try {
			for (int i = 0; i < num; i++) {
				GameObject unit = tileinfo.units[tileinfo.units.Count -1];
				tileinfo.units.RemoveAt(tileinfo.units.Count - 1);
				Destroy(unit);
				Debug.Log("Removed a unit from " + gameObject.name);

			}
		} catch (ArgumentOutOfRangeException) {
				Debug.Log("Attemped to remove " + (num - initialunits).ToString() + " units more than existed on " + gameObject.name);
		}

	}
}