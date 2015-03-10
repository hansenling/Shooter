using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public int maxHealth = 10;
	public int currHealth = 10;
	public GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag ("Player");
		this.gameObject.rigidbody.velocity = Random.Range (0.01f, 0.2f) * (target.transform.position - this.gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
			
		if (currHealth <= 0) {
			Destroy(this.gameObject);
			GameObject score = GameObject.FindGameObjectWithTag("Score");
			score.GetComponent<ScoreText>().displayScore +=1;
		}
	}
	void OnCollisionEnter(Collision collision){
		if (collision.collider.gameObject.tag == "Player") {
			print ("DEAD");
			Application.Quit ();
		}
	}
}
