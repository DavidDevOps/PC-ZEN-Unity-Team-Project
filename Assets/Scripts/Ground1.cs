using UnityEngine;
using System.Collections;

public class Ground1 : MonoBehaviour {
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.name == "Character")
		{
			CharacterMove.ground = 1;
		}
	}
}
