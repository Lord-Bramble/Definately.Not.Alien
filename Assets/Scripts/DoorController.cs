using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //public Animator doorAnimator;
    [SerializeField] private Animator doorAnim = null;

    [SerializeField] private string openAnimationName = "Test Door Open";
    [SerializeField] private string closeAnimationName = "Test Door Close";


    private bool enemyInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemyInside = true;
            //doorAnimator.SetBool("isOpen", true);
            doorAnim.Play(openAnimationName, 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemyInside = false;
            //doorAnimator.SetBool("isOpen", false);
            doorAnim.Play(closeAnimationName, 0, 0.0f);
        }
    }
}
