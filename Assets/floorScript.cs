using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorScript : BaseBehavior {

    public int floorNumber;
    // Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

	public void onParticleCollision() {
		StateContainer.Instance.particleHit(floorNumber);
	}
}
