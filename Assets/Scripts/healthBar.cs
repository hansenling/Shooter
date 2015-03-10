using UnityEngine;
using System.Collections;

public class healthBar : MonoBehaviour {
	public GameObject myGuy;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.localScale;
		float cHealth = myGuy.GetComponent<Health> ().currHealth;
		float mHealth = myGuy.GetComponent<Health> ().maxHealth;
		this.gameObject.renderer.material.color = new Vector4(1.0f-(0.3f * (cHealth / mHealth)), (cHealth / mHealth), 0, 1.0f);
		transform.localScale = new Vector3(myGuy.GetComponent<Health>().currHealth * .2f, 0.254f, 0.015f);
	}
}
