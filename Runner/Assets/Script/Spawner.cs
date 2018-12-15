using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject enemy;
	
	private float timeBtwSpawn;
	public float startTimeBtwSpawn;
	//public float decreaseTime;
	//public float minTime = 0.65f;
	
	// Update is called once per frame
	private void Update () {
		if(timeBtwSpawn <= 0){
			//int rand = Random.Range(0, enemyPattern.Length);
			Instantiate(enemy, transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;
			//startTimeBtwSpawn -= decreaseTime;
			/*if(startTimeBtwSpawn > minTime  ){
				startTimeBtwSpawn -= decreaseTime;
				}*/
		}
		else{
			timeBtwSpawn -= Time.deltaTime;
		}
	}
}
