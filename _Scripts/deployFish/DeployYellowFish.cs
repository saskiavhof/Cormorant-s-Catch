using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployYellowFish : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject yellowFishPrefab;

    public float respawnTime = 5.0f;

    //public float respawnGreenTime = 12.0f;


    private Vector2 screenBounds;

    private static DeployYellowFish instance;


    void Start()
    {
        instance = this;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());


    }

    public static DeployYellowFish GetInstance()
    {
        return instance;
    }

    void spawnFish()
    {

      GameObject c = Instantiate(yellowFishPrefab) as GameObject;
      c.GetComponent<Renderer>().enabled = true;
      c.SetActive(true);
      //c.transform.position = new Vector2(screenBounds.x - 50, Random.Range(-10f, 17f));
      c.transform.position = new Vector2(46f, Random.Range(-10f, 16f));
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
