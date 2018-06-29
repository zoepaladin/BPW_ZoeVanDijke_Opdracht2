using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private GameObject pickupObject;

	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(pickupObject == null)
            {
                int layer = LayerMask.NameToLayer("PickUp");
                RaycastHit hitInfo;
                if(Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo, 1.0f, 1 << layer))
                {
                    pickupObject = hitInfo.collider.gameObject;
                    pickupObject.transform.parent = transform;

                    ((Rigidbody)pickupObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
                }
                
            }

        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ((Rigidbody)pickupObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
            pickupObject.transform.parent = null;
        }
    }
}
