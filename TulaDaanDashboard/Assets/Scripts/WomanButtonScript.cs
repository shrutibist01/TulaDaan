using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanButtonScript : MonoBehaviour
{
    private GenderManager genderManager;

    void Start() {
        genderManager = FindObjectOfType<GenderManager>();
    }

    public void ButtonInteract() {
        genderManager.SetGender(GenderManager.Gender.Female);
        Debug.Log("Female Button Was clicked.");
    }

}
