using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;
    public Text xy;

    public float totalLapTime;
    public float totalCountdownTime;

    public CodeyMove codey;

    private float speed;

    public bool caneditxy;

    // Start is called before the first frame update
    void Start()
    {
        totalCountdownTime = float.Parse(startCountdown.text);
        totalLapTime = float.Parse(lapTime.text);

        speed = codey.Speed;
        codey.Speed = 0;

        caneditxy = true;
    }

    // Update is called once per frame
    void Update()
    {

        totalCountdownTime -= Time.deltaTime;

        startCountdown.text = Mathf.Floor(totalCountdownTime).ToString();

        if (totalCountdownTime <= 0 && totalCountdownTime > -1)
        {
            startCountdown.text = "GO!";
        }

        if (totalCountdownTime <= -1)
        {
            if (codey.Speed == 0)
            {
                codey.Speed = speed;
                startCountdown.text = "";
            }

            startCountdown.text = "";

            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Floor(totalLapTime).ToString();

            if (totalLapTime <= -0.1)
            {
                xy.text = "TIME's UP!!!";

                //caneditxy = false;
                
            }
        }
    }
}
