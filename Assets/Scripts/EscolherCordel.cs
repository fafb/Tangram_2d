using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EscolherCordel : MonoBehaviour {

	public Button buttonCordelUm;
	public Button buttonCordelDois;

	// Use this for initialization
	void Start () {
		buttonCordelUm = buttonCordelUm.GetComponent<Button> ();	
		buttonCordelDois = buttonCordelDois.GetComponent<Button> ();
	}
	
	public void StartCordelUm(){
		Application.LoadLevel ("tangram_1");
	}

	public void StartCordelDois(){
		Application.LoadLevel ("EscolherCordel");
	}
}
