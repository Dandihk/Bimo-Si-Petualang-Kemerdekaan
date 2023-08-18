using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel_pembahasan_akhir_all : MonoBehaviour
{
    public Button[] button_pembahasan_all;
    public GameObject[] panel_pembahasan_all;
    

    public void btn_panel_pembahasan_all(int btn_on)
    {
        for (int i = 0; i < button_pembahasan_all.Length; i++)
        {
            button_pembahasan_all[i].interactable = true;
            panel_pembahasan_all[i].SetActive(false);
        }

        for (int i = 0; i <= btn_on; i++)
        {
            button_pembahasan_all[btn_on].interactable = false;
            panel_pembahasan_all[btn_on].SetActive(true);
        }

    }
}
