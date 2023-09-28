using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckPointCounter counter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey")
        {
            if (counter.numberOfCheckpoints == counter.triggeredCheckpoints)
            {
                print("yey");
            }

            else
            {
                print("Chitter! Chitter!!!! 5709 ch3471n9!!111!1!1");
            }
        }
    }
}
