using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public static MouseManager y;

    public bool blah;

    [Header("Mouse Info")]
    public Vector3 clickStartLocation;
    public Vector3 launchVector;

    [Header("Physics")]
    public float launchForce;

    [Header("Bullet")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;

    private Transform old;

    // Start is called before the first frame update
    void Start()
    {
        y = this;
        old = GameObject.FindGameObjectWithTag("Respawn").transform;
    }

    public void inv()
    {
        Invoke("z", 3);
    }

    void z()
    {
        if (life.f.winnerwinner) return;
        life.f.remlif();
        slimeRigidbody.transform.position = old.position;
        slimeRigidbody.transform.rotation = old.rotation;
        slimeRigidbody.isKinematic = true;
        blah = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (blah) { return; }
        
        if (Input.GetMouseButtonDown(0))
        {

            clickStartLocation = Input.mousePosition;

        }

        if (Input.GetMouseButton(0))
        {

            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;

            launchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f
            );

            launchVector.Normalize();

        }

        if (Input.GetMouseButtonUp(0))
        {

            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(launchVector * launchForce, ForceMode.Impulse);

        }

    }
}
