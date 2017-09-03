using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class JsonReader : MonoBehaviour {

	public Class_GameBoard.GameBoard LoadMap()
    	{
        //Loads in map from json into a GameBoard object
        string path;
        string jsonString;
        Class_GameBoard.GameBoard board;

        path = Application.streamingAssetsPath + "/GameBoard1.json";
        jsonString = File.ReadAllText(path);
        board = JsonUtility.FromJson<Class_GameBoard.GameBoard>(jsonString);
        return board;
    }

//   public Class_GameSettings.GameSettings LoadSettings()
//    {
//        string path;
//        string jsonString;
//        Class_GameSettings.GameSettings settings;
//
//        path = Application.streamingAssetsPath + "/GameSettings1.json";
//        jsonString = File.ReadAllText(path);
//        settings = JsonUtility.FromJson<Class_GameSettings.GameSettings>(jsonString);
//        return settings;
//    }
}