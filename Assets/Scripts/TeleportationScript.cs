using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationScript : MonoBehaviour {

    public GameObject Teleported;
    public Vector3 hitpoint;

	void OnTriggerEnter(Collider col) {
        if (col.tag == "Teleportable")
        {


      //      if (.transform.eulerAngles.y < 90 || mainCamera.transform.eulerAngles.y > 270)
      //      {
      
                hitpoint = PortalScript.hit.transform.position + new Vector3(0, -2, 0);
                col.transform.position = hitpoint;
       //     }

        }
	}
}
