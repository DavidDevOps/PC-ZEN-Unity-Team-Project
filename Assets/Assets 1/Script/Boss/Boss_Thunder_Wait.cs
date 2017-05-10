using UnityEngine;
using System.Collections;

public class Boss_Thunder_Wait : MonoBehaviour { //여기에 애니메이션도 삽입
	
	float wtime = 0.8f;
	public GameObject thunder;
	// Update is called once per frame
	void Update () {
		wtime -= Time.deltaTime;
		if(wtime < 0)
		{
			Instantiate(thunder,this.transform.position,Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
