using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public float increment = 0.3f;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var t = this.gameObject.transform;
            var stream = this.transform.Find("SteamSpray");
            var pos = Camera.main.WorldToScreenPoint(stream.position);
            var dir = Input.mousePosition - pos;
            Quaternion toRotation = Quaternion.FromToRotation(stream.up, dir);
            
            t.Rotate(
                0,
                0,
                increment *  (toRotation.z > 0 ? 1f : -1f),
                UnityEngine.Space.Self
            );
        };

    }

    float getRotationFromMousePosition(Vector2 vec1) {
        return vec1.y > Screen.height / 2 ? 0.1f : -0.1f;
    }

}
