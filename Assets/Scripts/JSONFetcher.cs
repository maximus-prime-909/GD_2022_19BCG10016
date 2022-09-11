using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class JSONFetcher : MonoBehaviour
{
    public string json_URL = "https://s3.ap-south-1.amazonaws.com/superstars.assetbundles.testbuild/doofus_game/doofus_diary.json";
    public int speed;
    public int max_destroy;
    public int min_destroy;
    void Start()
    {
        StartCoroutine(fetchData());
    }

    IEnumerator fetchData()
    {

        WWW www = new WWW(json_URL);
        yield return www;
        if (www.error == null)
        {
            Debug.Log(www.text);
            processData(www.text);
        }

    }

    private void processData(string text)
    {
        JSONParser j_data = JsonUtility.FromJson<JSONParser>(text);
        Debug.Log(j_data.player_data.speed);
    }

}