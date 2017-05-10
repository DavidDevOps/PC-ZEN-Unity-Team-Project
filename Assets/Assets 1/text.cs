using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class text : MonoBehaviour {

	Text te;
	public static int php = 10000;
	void Start()
	{
		te = GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		te.text = CharacterStat._HP.ToString ();
	}

	public void hurt(int damage)
	{
		php -= damage;
	}
}
