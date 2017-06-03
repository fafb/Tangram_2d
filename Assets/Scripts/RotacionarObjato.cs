using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RotacionarObjato : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

            var selectedObject = Selection.activeGameObject;

            if (Input.GetButton("RotacionarAntHorario")){
                selectedObject.transform.Rotate(0, 0, Time.deltaTime+1);
            }
            if (Input.GetButton("RotacionarHorario"))
            {
                selectedObject.transform.Rotate(0, 0, Time.deltaTime - 1);
            }
    }
}
