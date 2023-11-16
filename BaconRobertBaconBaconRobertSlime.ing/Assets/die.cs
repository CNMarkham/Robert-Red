using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
 //   public life x;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            life.f.win();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
