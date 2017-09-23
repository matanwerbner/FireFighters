using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fx_Stream_Script : BaseBehavior {
    void Start () {
        GetComponent<EllipsoidParticleEmitter>().emit = true;
	}
	
	// Update is called once per frame
	void Update () {
      
	}
}
