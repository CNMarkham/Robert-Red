using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collectable : MonoBehaviour
{
    public AnimationCurve curve;
    public List<Transform> transforms;

    public float obptib;

    public float reverse;
    public float prev;

    // Start is called before the first frame update
    void Start()
    {

    }

    float pingpongcurve(float x)
    {
        // y=2\left|(x/p)-\operatorname{floor}((x/p)+1/2)\right|
        return 2 * Mathf.Abs(x - Mathf.Floor(x + 0.5f));
    }


    // Update is called once per frame
    void Update()
    {
        //405 -> 405/1000 -> 0.40 (0.405)
        //x -> x/y -> 0.x

        // x = 31.9382 -> x - floor(x) -> .9382 -> y * 100 -> z - floor(z) -> w / 100 -> 0.93

        // print(Time.time);


        if (Time.time == 0)
        {
            return; // pingpongcurve(dig(Time.time));
        }

        float e = pingpongcurve(Time.time);

        transform.position = new Vector3(
            (transforms[0].position.x * e + transforms[1].position.x * (1 - e)),
            (transforms[0].position.y * e + transforms[1].position.y * (1 - e)),
            (transforms[0].position.z * e + transforms[1].position.z * (1 - e))
        );


        //transform.position = Vector3.Lerp(transforms[0].position, transforms[1].position, curve.Evaluate(Time.time*obptib));
    }
}
