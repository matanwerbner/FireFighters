using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worl : MonoBehaviour {

    void OnParticleCollision(GameObject other)
    {
        Rigidbody body = other.GetComponent<Rigidbody>();
        if (body)
        {
            Vector3 direction = other.transform.position - transform.position;
            direction = direction.normalized;
            body.AddForce(direction * 5);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
            coll.gameObject.SendMessage("ApplyDamage", 10);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
