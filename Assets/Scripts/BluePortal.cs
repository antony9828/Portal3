using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePortal : MonoBehaviour {


    public float range = 100f;
    public Camera fpsCam;
    public GameObject Portal;
    GameObject model;
    public static RaycastHit bhit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && false)
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out bhit, range))
        {

            Debug.Log(bhit.transform.name);

            if (bhit.transform.gameObject.CompareTag("PortalOn"))
            {
                Debug.Log(bhit.transform.gameObject.CompareTag("PortalOn"));
                PortalOn target = bhit.transform.GetComponent<PortalOn>();
                Portal.transform.position = bhit.point;
                Portal.transform.rotation = bhit.transform.rotation;
                Destroy(model);
                model = Instantiate(Portal);

                // Portal = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                //     Debug.Log(hit.transform.gameObject.CompareTag("PortalOn"));
            }
        }
    }
}
