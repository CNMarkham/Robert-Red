using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{

    public GameObject box;
    public int boxes;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < boxes; i++)
        {
            GameObject itemboxclone = Instantiate(
                box.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject.gameObject,
                transform.position + new Vector3(i*10, 0, 0),
                transform.rotation
            );


        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
