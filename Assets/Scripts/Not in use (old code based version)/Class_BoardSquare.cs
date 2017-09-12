using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class_BoardSquare : MonoBehaviour {

    [System.Serializable]
    public class BoardSquare
    {
        public string name;
        public int number;
        public string type; // convert this to enum type maybe
        public int[] intNeighbours;
        public List<int> int_location;
        public List<int> int_rotation;
        public int mesh;
    }


}
