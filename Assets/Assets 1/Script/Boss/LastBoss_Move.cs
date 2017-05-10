using UnityEngine;
using System.Collections;

public class LastBoss_Move : MonoBehaviour {

	public GameObject Character;
	public float Speed = 2;
	public static int swit = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if((Character.transform.position.x - transform.position.x < 20) &&
		   (Character.transform.position.z - transform.position.z < 20) &&
		   (transform.position.x - Character.transform.position.x < 20) &&
		   (transform.position.z - Character.transform.position.z < 20) && (swit==1)
		   ){
			if (Character.transform.position.z+3.5 < transform.position.z) {
				transform.Translate (Vector3.back * Speed * Time.deltaTime);
			}
			if (Character.transform.position.z-3.5 > transform.position.z) {
				transform.Translate (Vector3.forward * Speed * Time.deltaTime);
			}
			if (Character.transform.position.x-8 > transform.position.x) {
				transform.Translate (Vector3.right * Speed * Time.deltaTime);
			}
			if (Character.transform.position.x+8 < transform.position.x) {
				transform.Translate (Vector3.left * Speed * Time.deltaTime);
			}
		}
	}
}
