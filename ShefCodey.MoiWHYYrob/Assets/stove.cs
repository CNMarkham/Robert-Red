using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stove : MonoBehaviour
{
    public GameObject toast;
    public GameObject friedEgg;
    public GameObject beams;
    public string cookedFood = "";
    public bool isCooking = false;
    public string sfc = "";

    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
        friedEgg.SetActive(false);
    }

    public void ToastBread()
    {
        isCooking = true;
        if (cookedFood != "") { return; }
        beams.SetActive(true);
        toast.SetActive(true);
        sfc = "toast";
        Invoke("Con", 2);
    }

    public void ToastEgg()
    {
        isCooking = true;
        if (cookedFood != "") { return; }
        beams.SetActive(true);
        friedEgg.SetActive(true);
        sfc = "friedegg";
        Invoke("Con", 2);
    }

    public void Con()
    {
        isCooking = false;
        cookedFood = sfc;
    }


    public void CleanStove()
    {
        beams.SetActive(false);
        toast.SetActive(false);
        friedEgg.SetActive(false);
        cookedFood = "";
    }
}
