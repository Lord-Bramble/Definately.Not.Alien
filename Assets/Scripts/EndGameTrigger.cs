using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndGameTrigger : MonoBehaviour
{
    public Text endGameText;





    private void OnTriggerEnter(Collider other)
    {
        endGameText.GetComponent<Text>().enabled = true;
    }
}
