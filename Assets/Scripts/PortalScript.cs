using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {


    public float range = 100f;
    public Camera fpsCam;
    public GameObject Portal;
    GameObject model;
    public static RaycastHit hit;
    int limit = 1;

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1") && false)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {


            if (hit.transform.gameObject.CompareTag("PortalOn"))
            {
                Debug.Log(hit.transform.gameObject.CompareTag("PortalOn"));
                PortalOn target = hit.transform.GetComponent<PortalOn>();
                Portal.transform.position = hit.point;
                Portal.transform.rotation = hit.transform.rotation;
                Destroy(model);
                model = Instantiate(Portal);
                // Portal = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                //  hit = new RaycastHit();
                /*     GameObject[] enemies = GameObject.FindGameObjectsWithTag("Portal");
                     if (enemies.Length > limit)
                     {
                         for (int i = limit; i < limit; i++)
                         {
                             Destroy(enemies[i]);
                         }
                     }
 */

                //     Debug.Log(hit.transform.gameObject.CompareTag("PortalOn"));
            }
        }
    }
}
