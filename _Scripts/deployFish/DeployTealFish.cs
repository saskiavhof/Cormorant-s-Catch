using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployTealFish : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tealFishPrefab;

    public float respawnTime = 5.0f;

    //public float respawnGreenTime = 12.0f;


    private Vector2 screenBounds;

    private static DeployTealFish instance;


    void Start()
    {
        instance = this;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());


    }

    public static DeployTealFish GetInstance()
    {
        return instance;
    }

    void spawnFish()
    {

      GameObject b = Instantiate(tealFishPrefab) as GameObject;
      b.GetComponent<Renderer>().enabled = true;
      b.SetActive(true);
      //b.transform.position = new Vector2(screenBounds.x - 50, Random.Range(-10f, 17f));
      b.transform.position = new Vector2(50f, Random.Range(-10f, 16f));

    }




    IEnumerator fishWave()
    {
      while (true)

      {
        yield return new WaitForSeconds(respawnTime);
        spawnFish();
      }

    }








}
