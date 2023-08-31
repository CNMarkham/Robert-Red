using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class throwable : MonoBehaviour
{
    public GameObject objectthrown;
    public Vector3 offset;
    public int throwableCounter;
    public Text shuritext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && throwableCounter > 0)
        {
            throwableCounter -= 1;
            shuritext.text = throwableCounter.ToString();
            offset = new Vector3(1, 0, 0);
            offset = transform.localScale.x * offset;
            Vector3 throwableposition = transform.position + offset;
            var x =  Instantiate(objectthrown, throwableposition, transform.rotation);
            x.tag = "projectile";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "collectable")
        {
            Destroy(collision.gameObject);
            throwableCounter += 1;
            shuritext.text = throwableCounter.ToString();
        }

        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
