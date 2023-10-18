using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    NavMeshAgent nv;
    Transform x;

    // Start is called before the first frame update
    void Start()
    {
        nv = gameObject.GetComponent<NavMeshAgent>();
        x = GameObject.FindGameObjectWithTag("cone").transform;
    }

    // Update is called once per frame
    void Update()
    {
        nv.destination = x.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cone")
        {
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
