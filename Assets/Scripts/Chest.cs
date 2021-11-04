using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
public class Chest : MonoBehaviour
{
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
    UnityWebRequest item_Get = UnityWebRequest.Get("http://localhost/GetItems.php");
    yield return item_Get.SendWebRequest();
    if(item_Get.error != null)
    {
        Debug.Log("Error: " + item_Get.error);
    }
    else
    {
        string data = item_Get.downloadHandler.text;
        Debug.Log(data);
    }
}
}

