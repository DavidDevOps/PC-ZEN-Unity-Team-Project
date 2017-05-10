using UnityEngine;
using System.Collections;

public class Enemy_Near_Move : MonoBehaviour {
		public GameObject Character;
		float Enemy_Speed = 1f;
		// Use this for initialization
		void Start () {
			Character = GameObject.Find ("Character");
		}
		
		// Update is called once per frame
		void Update () {
			if((Character.transform.position.x - transform.position.x < 8) &&
			   (Character.transform.position.z - transform.position.z < 3) &&
			   (transform.position.x - Character.transform.position.x < 8) &&
			   (transform.position.z - Character.transform.position.z < 3)
			   ){
				if (Character.transform.position.z+0.1 < transform.position.z) {
					transform.Translate (Vector3.back * Enemy_Speed * Time.deltaTime);
				}
				if (Character.transform.position.z-0.1 > transform.position.z) {
					transform.Translate (Vector3.forward * Enemy_Speed * Time.deltaTime);
				}
				if (Character.transform.position.x-2 > transform.position.x) {
					transform.Translate (Vector3.right * Enemy_Speed * Time.deltaTime);
				}
				if (Character.transform.position.x+2 < transform.position.x) {
					transform.Translate (Vector3.left * Enemy_Speed * Time.deltaTime);
				}
			}
		}

}
