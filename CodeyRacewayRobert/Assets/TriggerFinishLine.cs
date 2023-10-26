
using UnityEngine;

using System.Net.Http;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckPointCounter counter;
    public TimersCountdown tc;

    private void Start()
    {
    }

    private void getip()
    {
        HttpClient httpClient = new HttpClient();
        string result = httpClient.GetStringAsync("https://httpbin.org/ip").Result;
        
        tc.xy.text = "FOUND: " + result;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey" && tc.caneditxy)
        {
            if ((counter.numberOfCheckpoints == counter.triggeredCheckpoints))
            {
                tc.xy.text = "YOU WON!!!";
                tc.codey.Speed = 0;

                print("something");
            }

            else
            {

                print("Isauojhd");

                tc.xy.text = "TRACING IP ADDRESS";
                tc.codey.Speed = 0;

                Invoke("getip", 3);
            }
        }
    }
}
