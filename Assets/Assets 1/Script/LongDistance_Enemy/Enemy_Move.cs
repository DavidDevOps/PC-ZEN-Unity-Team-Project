using UnityEngine;
using System.Collections;
/// <summary>
/// E////////////////////////////////몬스터의 이동 스크립트/// </summary>
public class Enemy_Move : MonoBehaviour {

	public GameObject Character;
	float Enemy_Speed = 1;
	public static int swit = 1;
	// Use this for initialization
	void Start () {
		Character = GameObject.Find ("Character");
	}
	
	// Update is called once per frame
	void Update () {
		if((Character.transform.position.x - transform.position.x < 8) &&
		   (Character.transform.position.z - transform.position.z < 3) &&
		   (transform.position.x - Character.transform.position.x < 8) &&
		   (transform.position.z - Character.transform.position.z < 3) && (swit==1)
		   ){
			if (Character.transform.position.z+0.3 < transform.position.z) {
				transform.Translate (Vector3.back * Enemy_Speed * Time.deltaTime);
			}
			if (Character.transform.position.z-0.3 > transform.position.z) {
				transform.Translate (Vector3.forward * Enemy_Speed * Time.deltaTime);
			}
			if (Character.transform.position.x-5 > transform.position.x) {
				transform.Translate (Vector3.right * Enemy_Speed * Time.deltaTime);
			}
			if (Character.transform.position.x+5 < transform.position.x) {
				transform.Translate (Vector3.left * Enemy_Speed * Time.deltaTime);
			}
		}
	}
}
