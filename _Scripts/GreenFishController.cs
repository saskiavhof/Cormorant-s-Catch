using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenFishController : MonoBehaviour
{
    public float speed;
    public float startBound, endBound;
    public Rigidbody2D m_Rigidbody;

    public GameObject greenFishPrefab;



    void Start()
    {
      m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      Vector2 newPos = new Vector2(gameObject.transform.position.x + speed, gameObject.transform.position.y);

      if(newPos.x >= endBound || newPos.x <= startBound)
      {
        speed = speed * (-1);

        // Flip the direction of the fish sprite
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
      }
      gameObject.transform.position = newPos;

    }



}

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the fish
            Destroy(gameObject);

            // Respawn the fish at a random location
            Vector2 spawnPosition = new Vector2(-25f, Random.Range(-10f, 17f));
          //  Instantiate(greenFish, spawnPosition, Quaternion.identity);
            GameObject newFish = Instantiate(greenFish, spawnPosition, Quaternion.identity);
            Rigidbody2D newFishRigidbody = newFish.GetComponent<Rigidbody2D>();
            BoxCollider2D newFishBoxCollider = newFish.AddComponent<BoxCollider2D>();


            // Set the speed and boundaries for the cloned fish
            GreenFishController newFishController = newFish.GetComponent<GreenFishController>();
            newFishController.startBound = startBound;
            newFishController.endBound = endBound;
            newFishController.speed = speed;

            count++;
            MoveAgain();

        }

        void MoveAgain()
        {
          Vector2 newPos = new Vector2(greenFish.transform.position.x + speed, greenFish.transform.position.y);

          if(newPos.x >= endBound || newPos.x <= startBound)
          {
            speed = speed * (-1);

            // Flip the direction of the fish sprite
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
          }
          greenFish.transform.position = newPos;


        }
    }*/
/*

    void OnDestroy()
    {
        Debug.Log("Fish destroyed!");
        //Invoke("Respawn", 1f);
        Respawn();

        //greenFishCount--; // Decrement the greenfish count when a fish is destroyed
        //if (greenFishCount == 0)
      //  { // If there are no greenfish left in the scene, respawn a new one
        //    Respawn();
      //  }
    }

    void Respawn()
    {
      Debug.Log("Respawning fish...");
      GameObject a = Instantiate(greenFishPrefab) as GameObject;
      GreenFishController newFishController = a.GetComponent<GreenFishController>();

    /*  newFishController.startBound = startBound;
      newFishController.endBound = endBound;
      newFishController.speed = speed;*/
/*
      Vector2 spawnPosition = new Vector2(-25f, Random.Range(-10f, 16f));
      a.transform.position = spawnPosition;

      Debug.Log("Fish is somewhere!");
      //greenFishCount++;
    }*/
