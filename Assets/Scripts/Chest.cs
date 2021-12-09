using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public GameObject uiObject;
    public GameObject uiObject2;
    private string item = "";
    void Start()
    {
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Robot Kyle" && GameVariables.keys > 0)
        {
            GameVariables.keys--;
            Debug.Log("key used on chest");
            StartCoroutine(GetItem());
        }
    }
IEnumerator GetItem()
{
    UnityWebRequest item_Get = UnityWebRequest.Get("http://localhost/GetRandom.php");
    yield return item_Get.SendWebRequest();
    if(item_Get.error != null)
    {
        Debug.Log("Error: " + item_Get.error);
    }
    else
    {
        item = item_Get.downloadHandler.text;
        Debug.Log(item);
        uiObject.GetComponent<Text>().text = "You got a " + item;
        uiObject.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        uiObject.SetActive(false);
        uiObject2.SetActive(true);
    }
}
}

