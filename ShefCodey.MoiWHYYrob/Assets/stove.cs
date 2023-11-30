using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stove : MonoBehaviour
{
    public GameObject toast;
    public GameObject friedEgg;
    public GameObject beams;
    public string cookedFood = "";

    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
        friedEgg.SetActive(false);
    }

    public void ToastBread()
    {
        if (cookedFood != "") { return; }
        beams.SetActive(true);
        toast.SetActive(true);
        cookedFood = "toast";
    }

    public void ToastEgg()
    {
        if (cookedFood != "") { return; }
        beams.SetActive(true);
        friedEgg.SetActive(true);
        cookedFood = "friedegg";
    }


    public void CleanStove()
    {
        beams.SetActive(false);
        toast.SetActive(false);
        friedEgg.SetActive(false);
        cookedFood = "";
    }
}
