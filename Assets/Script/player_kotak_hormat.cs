using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_kotak_hormat : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Hormat")
        {
            GetComponent<Animator>().SetLayerWeight(2, 1);
            //GetComponent<Animator>().SetLayerWeight(1, 0);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Hormat")
        {
            GetComponent<Animator>().SetLayerWeight(2, 0);
            //GetComponent<Animator>().SetLayerWeight(1, 0);

        }
    }
}

