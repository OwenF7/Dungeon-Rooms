using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject wallToDisappear;

    public GameObject objectsToAppear;

    // Start is called before the first frame update
    void Start()
    {
        objectsToAppear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Grav Item")
        {
            wallToDisappear.SetActive(false);
            objectsToAppear.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Grav Item")
        {
            wallToDisappear.SetActive(true);
            objectsToAppear.SetActive(false);
        }
    }
}
