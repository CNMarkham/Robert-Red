using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedupcodey : MonoBehaviour
{
    CodeyMove cm;

    // Start is called before the first frame update
    void Start()
    {
        cm = GameObject.FindGameObjectWithTag("Codey").GetComponent<CodeyMove>();

        cm.Speed = 2000;

        Invoke("lowerspeed", 5);
    }

    void lowerspeed()
    {
        cm.Speed = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
