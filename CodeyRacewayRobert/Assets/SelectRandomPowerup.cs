    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public int randomnum;
    public List<GameObject> poweruplist;
    public GameObject chosenPowerup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            if (chosenPowerup != null)
            {
                chosenPowerup.transform.localPosition = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z) + transform.forward*2;
                chosenPowerup.transform.rotation = transform.rotation;

                Instantiate(chosenPowerup);
                chosenPowerup = null;
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "itemboxes")
        {
            randomnum = Random.Range(0, poweruplist.Count);
            chosenPowerup = poweruplist[randomnum];
        }
    }
}
