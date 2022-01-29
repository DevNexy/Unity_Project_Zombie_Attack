using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public float maxDistance = 1000000;
	RaycastHit hit;

	public GameObject decalHitWall;

	public float floatInfrontOfWall;

	public GameObject bloodEffect;

	public LayerMask ignoreLayer;

	public static int attackNum = 0;
	
	void Update () {

		if(Physics.Raycast(transform.position, transform.forward,out hit, maxDistance, ~ignoreLayer)){
			if(decalHitWall){
				if(hit.transform.tag == "LevelPart"){
					Instantiate(decalHitWall, hit.point + hit.normal * floatInfrontOfWall, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
				}
				if(hit.transform.tag == "Enemy"){
					GameObject Enemy = GameObject.FindWithTag("Enemy");
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(Enemy);
					attackNum += 1;
				}
			}		
			Destroy(gameObject);
		}
		Destroy(gameObject, 0.1f);
	}

}
