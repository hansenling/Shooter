using UnityEngine;
using System.Collections;

public class startBullet : MonoBehaviour {
	public GameObject direction = new GameObject();
	public float lifeTime = 10.0f;

	// Use this for initialization
	void Start () {
		Vector3 bulletDirection = direction.transform.forward;
		bulletDirection.y = (float)direction.transform.up.y;
		print (direction.transform.up);
		this.rigidbody.velocity = direction.transform.forward * 20;
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime -= Time.deltaTime;
		if (lifeTime < 0.0f) {
			Destroy (this.collider.gameObject);

		}
	}
	void OnCollisionEnter(Collision collision){

		if (collision.collider.tag == "badguy") {

			collision.collider.gameObject.GetComponent<Health>().currHealth -= 1;
			Destroy (this.collider.gameObject);
		}
	}
}
