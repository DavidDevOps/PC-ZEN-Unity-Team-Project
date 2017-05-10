using UnityEngine;
using System.Collections;

public class Ground2 : MonoBehaviour {
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.name == "Character")
		{
			CharacterMove.ground = 3;
		}
	}
}
