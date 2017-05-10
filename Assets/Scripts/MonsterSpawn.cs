using UnityEngine;
using System.Collections;

public class MonsterSpawn : MonoBehaviour {
	public GameObject monster;
	Vector3 spawnspot;
	static public int count = 0;
	float mx,mz;
	GameObject des;
	bool swit = false;

	void Start()
	{
		StartCoroutine (spawn ());
	}

	IEnumerator spawn()
	{
		if(count < 20 && BGM_PLAY_STAGE.swit == true)
		{
			mx = Random.Range (-3f,44f);
			mz = Random.Range (20f,28f);
			spawnspot = new Vector3 (mx,transform.position.y,mz);

			Instantiate (monster,spawnspot,Quaternion.identity);
			count++;
		}
		yield return new WaitForSeconds(3);
		StartCoroutine(spawn ());
	}
}