using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Robot Kyle")
        {
            GameVariables.keys += 1;
            Debug.Log("key picked up");
            Destroy(gameObject);
        }
    }
}
