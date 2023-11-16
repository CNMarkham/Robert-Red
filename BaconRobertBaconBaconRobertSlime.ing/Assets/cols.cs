using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cols : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (MouseManager.y.blah) { return;  }
        if (collision.gameObject.CompareTag("box"))
        {
            MouseManager.y.blah = true;
            MouseManager.y.inv();
        }

        if (collision.gameObject.CompareTag("kv"))
        {
            MouseManager.y.blah = true;
            MouseManager.y.inv();
        }
    }
}
