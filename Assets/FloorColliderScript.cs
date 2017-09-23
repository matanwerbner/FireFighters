using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorColliderScript : MonoBehaviour {
	
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnParticleCollision(GameObject other)
    {
		transform.parent.gameObject.GetComponent<FloorScript>().onParticleCollision();
    }
}
