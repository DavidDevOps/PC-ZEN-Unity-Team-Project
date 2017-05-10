using UnityEngine;
using System.Collections;

public class LastBoss_Attack : MonoBehaviour {

	public GameObject character;
	static public int look; //1은 왼쪽
	int skill;
	static public bool switc = true;

	public GameObject character_down; // 공격스킬 생성 위치
	public GameObject earth_wait; //지진 공격 스킬
	
	public GameObject thunder_wait; //번개 떨구기전에 위치 알려줌

	public AudioClip knuck;

	void Start () {
		StartCoroutine (ta (0.0f));
	}

	IEnumerator ta(float wait)
	{
		switc = true;
		if (character.transform.position.z+10.5 < transform.position.z) {
		}
		else if (character.transform.position.z-10.5 > transform.position.z && switc==true) {
		}
		else if (character.transform.position.x > transform.position.x && switc==true) {
			if(character.transform.position.x - transform.position.x < 10 && switc==true) //사거리 
			{
				LastBoss_Move.swit=0;
				look = 0;
				skill = Random.Range(1,4);
				switch(skill)
				{
					case 1:
						Instantiate(earth_wait,character_down.transform.position,Quaternion.identity);
						yield return new WaitForSeconds(2.0f);
						switc = false;
						break;
					case 2:
						Instantiate(thunder_wait,character_down.transform.position,Quaternion.identity);
						yield return new WaitForSeconds(1.0f);
						switc = false;
						break;
					case 3:
					case 4: // 넉백
						AudioSource.PlayClipAtPoint(knuck,transform.position);
						character.rigidbody.AddForce(Vector3.right * 100,ForceMode.VelocityChange);
						yield return new WaitForSeconds(2.0f);
						break;
					default :
						break;
				}

			}
		}
		else if (character.transform.position.x < transform.position.x && switc==true) {
			if(transform.position.x - character.transform.position.x < 10 && switc==true) // 사거리 
			{
				LastBoss_Move.swit=0;
				look = 1;
				skill = Random.Range(1,4);
				switch(skill)
				{
					case 1:
						Instantiate(earth_wait,character_down.transform.position,Quaternion.identity);
						yield return new WaitForSeconds(1.0f);
						switc = false;
						break;
					case 2:
						Instantiate(thunder_wait,character_down.transform.position,Quaternion.identity);
						yield return new WaitForSeconds(1.0f);
						switc = false;
						break;
					case 3:
					case 4: // 넉백
						AudioSource.PlayClipAtPoint(knuck,transform.position);
						character.rigidbody.AddForce(Vector3.left * 100,ForceMode.VelocityChange);
						yield return new WaitForSeconds(2.0f);
						break;
					default :
						break;
				}
			}
		};
		LastBoss_Move.swit = 1;
		yield return new WaitForSeconds(1.5f);
		StartCoroutine (ta (0.7f));
	}
}
