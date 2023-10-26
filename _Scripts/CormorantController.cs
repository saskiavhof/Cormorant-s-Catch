using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CormorantController : MonoBehaviour
{
    public float speed;
    public float startBound, endBound;
    private Vector2 newPos;
    public Rigidbody2D m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
      m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.LeftArrow))
      {
        float newX = gameObject.transform.position.x - speed;
        float newY = gameObject.transform.position.y;
        newPos = new Vector2(newX, newY);
        gameObject.transform.position = newPos;

      }
      if(Input.GetKey(KeyCode.RightArrow))
      {
        float newX = gameObject.transform.position.x + speed;
        float newY = gameObject.transform.position.y;
        newPos = new Vector2(newX, newY);
        gameObject.transform.position = newPos;

      }
      if(Input.GetKey(KeyCode.UpArrow))
      {
        if (transform.rotation.eulerAngles.z == 180f)
        {
          // Do nothing
        }
        else
        {
          transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
        }
        m_Rigidbody.velocity = -transform.up * speed;

        transform.Rotate(new Vector3(0, 0, 1));
        float newX = gameObject.transform.position.x;
        float newY = gameObject.transform.position.y + speed;
        newPos = new Vector2(newX, newY);
        gameObject.transform.position = newPos;

      }
      if(Input.GetKey(KeyCode.DownArrow))
      {
        if (transform.rotation.eulerAngles.z == 0f)
        {
          // Do nothing
        }
        else
        {
          transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        m_Rigidbody.velocity = -transform.up * speed;

        float newX = gameObject.transform.position.x;
        float newY = gameObject.transform.position.y - speed;
        newPos = new Vector2(newX, newY);
        gameObject.transform.position = newPos;

      }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bigFish")
        {
          StartCoroutine(Stun());
        }

        if (collision.gameObject.tag == "smallFish")
        {
          StartCoroutine(Stun());
        }
        if (collision.gameObject.tag == "notFish")
        {
          StartCoroutine(Stun());
        }
    }

    private IEnumerator Stun()
    {
      speed = 0;
      yield return new WaitForSeconds(0.2f);
      speed = 0.01F; // replace 5 with the original value of speed
    }

}
