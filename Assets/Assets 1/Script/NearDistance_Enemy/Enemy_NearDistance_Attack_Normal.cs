using UnityEngine;
using System.Collections;
/// <summary>
/// E///////////////////////////몬스터의 근접공격 스크립트/// </summary>
public class Enemy_NearDistance_Attack_Normal :MonoBehaviour {

	public AudioClip atck;
	public GameObject character;
	static public bool switc = true;
	static public int look; //1은 왼쪽
	public float distance = 3.5f;
	public int damage; //데미지
	bool attackon = false;
	void Awake()
	{
		character = GameObject.Find ("Character");
		StartCoroutine (ta(0.0f));
	}

	void Update()
	{
		damage = this.gameObject.GetComponent<Monster_Status> ().Damage;
	}

	IEnumerator ta(float wait)
	{
		switc = true;
		if (character.transform.position.z+1 < transform.position.z) {
		}
		else if (character.transform.position.z-1 > transform.position.z && switc==true) {
		}
		else if (character.transform.position.x > transform.position.x && switc==true) {
			if(character.transform.position.x - transform.position.x < distance && switc==true)//인식범위
			{
				Enemy_Move.swit=0;
				look = 0;
				switc = false;
				attackon = true;
				yield return new WaitForSeconds(1.0f);//애니메이션 재생시간(임시)
				attackon = false;
			}
		}
		else if (character.transform.position.x < transform.position.x && switc==true) {
			if(transform.position.x - character.transform.position.x < distance && switc==true) //인식범위
			{
				Enemy_Move.swit=0;
				look = 1;
				switc = false;
				attackon = true;
				yield return new WaitForSeconds(1.0f);//애니메이션 재생시간(임시)
				attackon = false;
			}
		};
		Enemy_Move.swit = 1;
		yield return new WaitForSeconds(wait);
		StartCoroutine (ta (2.0f));//대기시간
	}

	void OnTriggerStay(Collider other)
	{
		if(attackon == true)
		{
			if(other.name=="Character")
			{
				AudioSource.PlayClipAtPoint(atck,transform.position);
				CharacterStat._HP -= damage;
				attackon = false;
			}
		}
	}
}