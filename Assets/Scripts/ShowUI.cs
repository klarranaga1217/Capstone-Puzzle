using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Robot Kyle")
        {
            StartCoroutine(DelayText(1f));
        }
    }
    IEnumerator DelayText(float waitTime)
    {
        uiObject.SetActive(true);
        Debug.Log("textUp");
        yield return new WaitForSecondsRealtime(waitTime);
        Debug.Log("textDown");
        uiObject.SetActive(false);
    }
}
