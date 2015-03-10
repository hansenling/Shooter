using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public GameObject bullet;
	public double myTimerStart = 2.0f;
	static double myTimer;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTimer -= Time.deltaTime;
		if (myTimer < 0.0f) {
			bullet.GetComponent<startBullet>().direction = GameObject.FindGameObjectWithTag("MainCamera");
			bullet.GetComponent<startBullet>().lifeTime = 10.0f;
			Instantiate (bullet, this.transform.position, Quaternion.identity);

			myTimer = myTimerStart;

		}
	}
}
