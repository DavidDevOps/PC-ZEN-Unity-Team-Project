using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	// Use this for initialization
	public static bool swit;
	void Start () {
		swit = true;
		StartCoroutine (PlayTime());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator PlayTime()
	{
		yield return new WaitForSeconds(6.4f);
		Destroy (this.gameObject);
		swit = false;
	}
}
