using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    // Function Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    // Update is called once per frame
    void Update()
    {
        //create a ray at the center of the camera, shooting outwards
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray. origin, ray.direction * distance);
        //RaycastHit hitInfo;
        // if (Physics.Raycast(ray, out hitInfo,distance,mask))
        // {
        //     if(hitInfo.collider.GetComponent<Interactable>() != null)
        //     {
        //         Debug.Log(hitInfo.collider.GetComponent<Interactable>().promptMessage);
        //     }
        // }
    }
}
