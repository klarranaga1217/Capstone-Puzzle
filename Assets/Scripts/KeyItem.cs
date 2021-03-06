using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Robot Kyle")
        {
            GameVariables.keys += 1;
            Debug.Log("key picked up");
            StartCoroutine(DelayText(2f));
        }
    }
    IEnumerator DelayText(float waitTime)
    {
        uiObject.SetActive(true);
        Debug.Log("textUp");
        yield return new WaitForSecondsRealtime(waitTime);
        Debug.Log("textDown");
        uiObject.SetActive(false);
        Destroy(gameObject);
    }
}
