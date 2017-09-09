using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx_Stream_Script : MonoBehaviour {
    void Start () {
        this.GetComponent<EllipsoidParticleEmitter>().emit = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
