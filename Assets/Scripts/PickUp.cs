using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp: MonoBehaviour
{
    public GameObject item;
    public GameObject tempParent;
    public Transform hold;

    void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnMouseDown()
    {
        Debug.Log("Press");
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
        this.transform.position = hold.transform.position;
        this.transform.rotation = hold.transform.rotation;
        item.transform.parent = tempParent.transform;
    }

    void OnMouseUp()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = hold.transform.position;
    }
}
