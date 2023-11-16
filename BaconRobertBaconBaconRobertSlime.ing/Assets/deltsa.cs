using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltsa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            life.f.st = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

            if (other.CompareTag("Player"))
        {
            life.f.st = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life.f.st)
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
