using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Antidote : MonoBehaviour
{
    public GameObject ButtonToEnable;
    public bool gotAntidote = false;
    public Text textToChange; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gotAntidote = true;
            ButtonToEnable.GetComponent<BoxCollider>().enabled = true;
            //Lockcheck takes place at button.

            ; 
            Destroy(gameObject);
        }
        
    }
}
