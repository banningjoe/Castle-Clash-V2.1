using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Class_GameBoard : MonoBehaviour
{

    [System.Serializable]
    public class GameBoard
    {
        public Class_BoardSquare.BoardSquare[] grid;
       
    }
}