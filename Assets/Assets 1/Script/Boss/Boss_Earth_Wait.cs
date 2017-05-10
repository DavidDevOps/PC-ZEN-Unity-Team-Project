using UnityEngine;
using System.Collections;

public class Boss_Earth_Wait : MonoBehaviour {

	float wtime = 1.0f;
	public GameObject earth;
	// Update is called once per frame
	void Update () {
		wtime -= Time.deltaTime;
		if(wtime < 0)
		{
			Instantiate(earth,this.transform.position,Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
