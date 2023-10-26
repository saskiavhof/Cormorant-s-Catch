using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployGreenFish : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject greenFishPrefab;

    public float respawnTime = 5.0f;

    //public float respawnGreenTime = 12.0f;


    private Vector2 screenBounds;

    private static DeployGreenFish instance;


    void Start()
    {
        instance = this;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());


    }

    public static DeployGreenFish GetInstance()
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
    }




    IEnumerator fishWave()
    {
      int aCount = GameObject.FindGameObjectsWithTag("bigFish").Length;

      if (aCount >= 7)
      {
        yield return new WaitForSeconds(respawnTime);
        yield return new WaitForSeconds(respawnTime);
      }

      while (true)

      {
        yield return new WaitForSeconds(respawnTime);
        spawnFish();
      }

    }








}
