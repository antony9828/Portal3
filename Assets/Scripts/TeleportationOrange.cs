using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationOrange : MonoBehaviour {

    public GameObject Teleported;
    public Vector3 hitpoint;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Teleportable")
        {

            hitpoint = BluePortal.bhit.transform.position + new Vector3(0, -2, 0);
            col.transform.position = hitpoint;

        }
    }
}
