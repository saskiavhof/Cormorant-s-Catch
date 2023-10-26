using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowFishController : MonoBehaviour
{
  public float speed;
  public float startBound, endBound;
  public Rigidbody2D m_Rigidbody;



  void Start()
  {
    m_Rigidbody = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    Vector2 newPos = new Vector2(gameObject.transform.position.x + speed, gameObject.transform.position.y);

    if(newPos.x <= endBound || newPos.x >= startBound)
    {
      speed = speed * (-1);
      transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));

      // Flip the direction of the fish sprite
      Vector3 newScale = transform.localScale;
      newScale.x *= -1;
      transform.localScale = newScale;
    }
    gameObject.transform.position = newPos;
  }

}
