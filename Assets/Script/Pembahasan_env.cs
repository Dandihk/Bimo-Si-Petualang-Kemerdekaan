using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pembahasan_env : MonoBehaviour
{

    public GameObject popup_notif_pembahasan;
    Player_control controls;
    public GameObject pop_pembahasan;
    public int nomor_pembahasan;
    public Pembahasan_manager pembahasan_;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            controls = new Player_control();
            controls.Enable();
            controls.Move.Enter.performed += context =>
            {
                //pop_pembahasan.SetActive(true);
                pembahasan_.panel_on(nomor_pembahasan);//
                //Debug.Log(nomor_pembahasan);
            };

            popup_notif_pembahasan.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            controls.Disable();
            popup_notif_pembahasan.SetActive(false);
        }
        
    }

}
