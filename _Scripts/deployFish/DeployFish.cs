using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployFish : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject greenFishPrefab;
    public GameObject yellowFishPrefab;
    public GameObject tealFishPrefab;
    public GameObject petBottlePrefab;

    public float respawnTime = 5.0f;

    //public float respawnGreenTime = 12.0f;


    private Vector2 screenBounds;

    private static DeployFish instance;


    void Start()
    {
        instance = this;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());


    }

    public static DeployFish GetInstance()
    {
        return instance;
    }

    void spawnFish()
    {

          GameObject a = Instantiate(greenFishPrefab) as GameObject;
          a.GetComponent<Renderer>().enabled = true;
          a.SetActive(true);
          //a.transform.position = new Vector2(screenBounds.x - 50, Random.Range(-10f, 17f));
          a.transform.position = new Vector2(-35f, Random.Range(-10f, 16f));

          GameObject b = Instantiate(tealFishPrefab) as GameObject;
          b.GetComponent<Renderer>().enabled = true;
          b.SetActive(true);
          //b.transform.position = new Vector2(screenBounds.x - 50, Random.Range(-10f, 17f));
          b.transform.position = new Vector2(50f, Random.Range(-10f, 16f));

          GameObject c = Instantiate(yellowFishPrefab) as GameObject;
          c.GetComponent<Renderer>().enabled = true;
          c.SetActive(true);
          //c.transform.position = new Vector2(screenBounds.x - 50, Random.Range(-10f, 17f));
          c.transform.position = new Vector2(46f, Random.Range(-10f, 16f));

          GameObject d = Instantiate(petBottlePrefab) as GameObject;
          d.GetComponent<Renderer>().enabled = true;
          d.SetActive(true);
        //  d.transform.position = new Vector2(screenBounds.x - 50, Random.Range(-10f, 17f));
          d.transform.position = new Vector2(-45f, Random.Range(-10f, 16f));




    }




    IEnumerator fishWave()
    {
      int aCount = GameObject.FindGameObjectsWithTag("bigFish").Length;
      int cCount = GameObject.FindGameObjectsWithTag("smallFish").Length;
      int dCount = GameObject.FindGameObjectsWithTag("notFish").Length;

      if (aCount >= 7)
      {
        yield return new WaitForSeconds(respawnTime);
        yield return new WaitForSeconds(respawnTime);
      }
      else if (cCount >= 5)
      {
        yield return new WaitForSeconds(respawnTime);
        yield return new WaitForSeconds(respawnTime);
      }
      else if (dCount >= 4)
      {
        yield return new WaitForSeconds(respawnTime);
      }

      while (true)

      {
        yield return new WaitForSeconds(respawnTime);
        spawnFish();
      }

    }








}
