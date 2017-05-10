using UnityEngine;
using System.Collections;

public class CharacterAttact : MonoBehaviour {
	public static bool attackswitch = false;
	// Use this for initialization
	void Start () {
		StartCoroutine (attack ());
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator attack()
	{
		if(Input.GetKey(KeyCode.A))
		{
			CharacterMove.swit = false;
			yield return new WaitForSeconds(0.5f);
			attackswitch = true;
			yield return new WaitForSeconds(1.0f);
			attackswitch = false;
			CharacterMove.swit = true;
		}
		yield return new WaitForSeconds(0);
		StartCoroutine (attack());
	}
}