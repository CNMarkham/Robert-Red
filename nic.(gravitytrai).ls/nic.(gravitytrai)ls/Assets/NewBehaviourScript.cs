using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public throwable direction;
    public float speed = 8;

    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<throwable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "projectile")
        {
            transform.position += direction.offset * Time.deltaTime * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) { 
    
        if (collision.gameObject.tag == "quad")
        {
                gameObject.SetActive(false);
        }

        if (gameObject.tag == "projectile")
        {


            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);    
            }

        }
    }
}
