using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButtonScript : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public void OnContinueButtonClicked()
    {

        if (page1 != null)
        {
            page1.SetActive(false);
        }

        if (page2 != null) {
            page2.SetActive(true);
        }
    }
}
