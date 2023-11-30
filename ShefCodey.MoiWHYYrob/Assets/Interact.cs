using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public stove stove;
    public string triggerName = "";
    public GameObject friedEggPrefab;
    public GameObject breadPrefab;
    public GameObject eggPrefab;
    public GameObject heldItem;
    public string heldItemName;
    
    void placehelditem() 
    {
        Destroy(heldItem);
        heldItemName = "";
    }

    void pickup(GameObject prefab, string name)
    {
        heldItem = Instantiate(prefab, transform, false);
        heldItem.transform.localPosition = new Vector3(0, 2, 2);
        heldItemName = name;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "Bread")
            {
                pickup(breadPrefab, triggerName);
            }

            if (triggerName == "Egg")
            {
                pickup(eggPrefab, triggerName);
            }

            if (triggerName == "ofout")
            {
                if (heldItemName == "Bread")
                {
                    print("Bread");
                    placehelditem();
                    stove.ToastBread();
                }

                else if (heldItemName == "Egg")
                {
                    print("Egg");
                    placehelditem();
                    stove.ToastEgg();
                }

                else
                {
                    if (stove.cookedFood == "toast")
                    {
                        print("pickup toast");
                        heldItem = Instantiate(breadPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 2, 2);
                        heldItemName = "toast";
                        stove.CleanStove();
                    }

                    if (stove.cookedFood == "friedegg")
                    {
                        print("pickup eggggggggFri");
                        heldItem = Instantiate(friedEggPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 2, 2);
                        heldItemName = "friedegg";
                        stove.CleanStove();
                    }
                }
            }
        
            if (triggerName == "Recivers")
            {
                if (heldItemName == "toast")
                {
                    placehelditem();
                    GameObject.Find("Recivers/FronchTost/Bread (1)").SetActive(true);
                }

                if (heldItemName == "friedegg")
                {
                    placehelditem();
                    GameObject.Find("Recivers/FronchTost/Egg (1)").SetActive(true);
                }
            }
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<BoxCollider>().isTrigger) { return; }
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.GetComponent<BoxCollider>().isTrigger) { return; }
        triggerName = "";
    }
}
