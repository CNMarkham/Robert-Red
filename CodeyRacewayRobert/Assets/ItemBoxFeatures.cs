using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //////// Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        var rot = Quaternion.Euler(0, 0, (float)(Time.deltaTime*15.0));

        ///// if (Time.deltaTime*1.5 < 1) { rot = Quaternion.Euler(1,1,1); } ;

        transform.rotation *= rot;
    }

    void x() { gameObject.SetActive(true);  }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Codey")
        {
            gameObject.SetActive(false);
            Invoke("x", 3);
        }
    }
}
