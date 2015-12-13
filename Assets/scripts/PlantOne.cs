using UnityEngine;
using System.Collections;

public class PlantOne : MonoBehaviour {

	public GameObject PlantOneObj;
	public GameObject PlayerObj;
	public bool StandingOnFlower = false;


	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		print ("Yes");
		StandingOnFlower = true;

		}
	void OnTriggerExit2D(Collider2D other){
		StandingOnFlower = false;
	}

	void Update(){
		if (StandingOnFlower == true) {
			if (Input.GetKeyDown (KeyCode.LeftControl) == true) {
				print ("o ya");


			
			}
		}
	}
}