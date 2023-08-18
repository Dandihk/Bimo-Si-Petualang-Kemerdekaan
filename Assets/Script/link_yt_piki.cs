using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class link_yt_piki : MonoBehaviour
{
    public void openlink(string link)
    {
        Application.OpenURL(link);
    }
}
