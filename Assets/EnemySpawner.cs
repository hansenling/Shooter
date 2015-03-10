using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	private float timeUntilSpawn = 1.0f;
	public GameObject myEnemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeUntilSpawn -= Time.deltaTime;
		if (timeUntilSpawn <= 0) {
			Vector3 spawnPosition = new Vector3(transform.position.x + Random.Range(-50.0f, 50.0f), transform.position.y + Random.Range(-30f, 30.0f), transform.position.z+Random.Range(-20.0f, 20.0f));
			Instantiate(myEnemy,spawnPosition, Quaternion.identity);
			timeUntilSpawn = Random.Range(0.0f, 5.0f);
		}
	}
}
