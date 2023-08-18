using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampu_pengetahuan : MonoBehaviour
{
    public GameObject popup_pengetahuan;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            popup_pengetahuan.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            popup_pengetahuan.SetActive(false);
        }

    }
}
