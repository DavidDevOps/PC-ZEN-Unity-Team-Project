using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {
	public GameObject warptarget;
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Character")
		{
			StartCoroutine( wait(2.0f));
			other.gameObject.transform.position = warptarget.transform.position;
		}
		
	}
	
	IEnumerator wait(float wait)
	{
		yield return new WaitForSeconds (wait);
	}
}
