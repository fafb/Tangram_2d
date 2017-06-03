using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public Button iniciar;

	void Start(){

		iniciar = iniciar.GetComponent<Button> ();
	
	}

	public void StartLevel(){
		Application.LoadLevel ("EscolherCordel");
	}
		
}
