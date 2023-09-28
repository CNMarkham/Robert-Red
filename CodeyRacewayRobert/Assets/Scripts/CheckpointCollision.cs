using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCollision : MonoBehaviour
{
    public bool didCollide;
    public CheckPointCounter counter;

    // Start is called before the first frame update
    void Start()
    {
        didCollide = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey" && didCollide == false)
        {
            didCollide = true;
            counter.triggeredCheckpoints += 1;
        }
    }
}
