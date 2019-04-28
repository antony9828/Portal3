using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

    public float x;
    public float y;
    public float z;

    void OnTriggerEnter(Collider col)
        
    {
        if (col.tag == "Teleportable")
        {
            //      if (.transform.eulerAngles.y < 90 || mainCamera.transform.eulerAngles.y > 270)
            //      {
         
            col.transform.position = new Vector3(x, y, z);
            //     }

        }
    }
}
