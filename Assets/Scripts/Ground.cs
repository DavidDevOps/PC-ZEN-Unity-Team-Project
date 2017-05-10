using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
	
	// Update is called once per frame
	void OnTriggerEnter () {
		CharacterMove.ground = 2;
	}
}
