using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pembahasan_manager : MonoBehaviour
{
    public GameObject[] panel_pembahasan;
    public Animator[] anim_pembahasan;
    //public int no;
    void Start()
    {
        //for (int i = 0; i <= panel_pembahasan.Length; i++)
        //{
        //    panel_pembahasan[i].transform.GetComponent<GraphicRaycaster>().enabled = true;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (panel_pembahasan[no].activeInHierarchy == true)
        //{
        //    for (int i = 0; i <= panel_pembahasan.Length; i++)
        //    {
        //        panel_pembahasan[no].transform.GetComponent<GraphicRaycaster>().enabled = true;
        //    }
        //}
    }

    public void panel_on(int no_pembahsan)
    {
        panel_pembahasan[no_pembahsan].SetActive(true);
    }

    public void btn_panel_pembahsan_exit(int no_pembahsan)
    {
        StartCoroutine(pembahasan_exit(no_pembahsan));
        //for (int i = 0; i <= panel_pembahasan.Length; i++)//
        //{
        //    StartCoroutine(pembahasan_exit(no_pembahsan));
        //}

    }

    IEnumerator pembahasan_exit(int no_pembahsan)
    {
        anim_pembahasan[no_pembahsan].SetTrigger("pembahasan_out");
        //panel_pembahasan[no_pembahsan].transform.GetComponent<GraphicRaycaster>().enabled = false;
        yield return new WaitForSeconds(1.4f);
        //panel_pembahasan[no_pembahsan].transform.GetComponent<GraphicRaycaster>().enabled = true;
        panel_pembahasan[no_pembahsan].SetActive(false);
        
    }

    public void btn_pembahasan_over(int no_cikgu)
    {
        panel_pembahasan[no_cikgu].SetActive(true);
    }

    public void btn_panel_pembahsan_cikgu_exit(int no_pembahsan)
    {
        StartCoroutine(pembahasan_cikgu_exit(no_pembahsan));
        //for (int i = 0; i <= panel_pembahasan.Length; i++)//
        //{
        //    StartCoroutine(pembahasan_exit(no_pembahsan));
        //}

    }

    IEnumerator pembahasan_cikgu_exit(int no_pembahsan)
    {
        anim_pembahasan[no_pembahsan].SetTrigger("materi");
        //panel_pembahasan[no_pembahsan].transform.GetComponent<GraphicRaycaster>().enabled = false;
        yield return new WaitForSeconds(1.4f);
        //panel_pembahasan[no_pembahsan].transform.GetComponent<GraphicRaycaster>().enabled = true;
        panel_pembahasan[no_pembahsan].SetActive(false);

    }
}
