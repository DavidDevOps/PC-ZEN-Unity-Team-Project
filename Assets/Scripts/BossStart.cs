using UnityEngine;
using System.Collections;

public class BossStart : MonoBehaviour {
	public GameObject start;
	public GameObject boss;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.name =="Character")
		{
			LastBoss_Status.Boss_HP = 100000;
			boss.transform.position = start.transform.position;
		}
	}
}
