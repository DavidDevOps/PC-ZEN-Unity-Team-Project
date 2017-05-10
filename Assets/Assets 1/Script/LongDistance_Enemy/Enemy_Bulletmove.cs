using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// E//////////////////////////////////////몬스터의 원거리 공격 객체의 이동 스크립트/// </summary>
public class Enemy_Bulletmove : MonoBehaviour {

	float Bullet_Life = 0.7f; //투사체의 체력
	public float Bullet_Speed = 15f; //투사체 속도
	public GameObject Character; //캐릭터
	int swit;
	int damage;
	public GameObject monster;

	void Start()
	{
		Character = GameObject.Find ("Character"); //캐릭터를 찾는다
		if(Character.transform.position.x < this.transform.position.x) //캐릭터가 왼쪽에 있을경우
		{
			swit=1;
		}
		else//캐릭터가 오른쪽에 있을경우
		{
			swit=2;
		}
	}

	void Update () {
		Bullet_Life -= Time.deltaTime;
		damage = monster.GetComponent<Monster_Status> ().Damage;
		if(Bullet_Life<=0)
		{
			Destroy(this.gameObject);
			if(Character.transform.position.x < this.transform.position.x) //캐릭터가 왼쪽에 있을경우
			{
				swit=1;
			}
			else//캐릭터가 오른쪽에 있을경우
			{
				swit=2;
			}
		}

		if(swit==1) //캐릭터가 왼쪽에 있을경우
		{
			transform.Translate(Vector3.left * Bullet_Speed * Time.deltaTime);
		}
		else//캐릭터가 오른쪽에 있을경우
		{
			transform.Translate(Vector3.right * Bullet_Speed * Time.deltaTime);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.name=="Character")
		{
			Destroy(this.gameObject);
			text.php -= damage;
		}
	}
}
