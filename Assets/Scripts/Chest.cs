using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Robot Kyle" && GameVariables.keys > 0)
        {
            GameVariables.keys--;
            Debug.Log("key used on chest");
            //Destroy(gameObject);
        }
    }
}
