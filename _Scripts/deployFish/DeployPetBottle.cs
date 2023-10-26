using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployPetBottle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject petBottlePrefab;

    public float respawnTime = 5.0f;

    //public float respawnGreenTime = 12.0f;


    private Vector2 screenBounds;

    private static DeployPetBottle instance;


    void Start()
    {
        instance = this;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());


    }

    public static DeployPetBottle GetInstance()
    {
        return instance;
    }

    void spawnFish()
    {

      GameObject d = Instantiate(petBottlePrefab) as GameObject;
      d.GetComponent<Renderer>().enabled = true;
      d.SetActive(true);
    //  d.transform.position = new Vector2(screenBounds.x - 50, Random.Range(-10f, 17f));
      d.transform.position = new Vector2(-45f, Random.Range(-10f, 16f));
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
