using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
  //  }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    //public void ButtonInteract() {
      //  Debug.Log("button was clicked"); // Added semicolon
    //}

    private GenderManager genderManager;

    void Start() {
        genderManager = FindObjectOfType<GenderManager>();
    }

    public void ButtonInteract() {
        genderManager.SetGender(GenderManager.Gender.Male);
        Debug.Log("Male Button Was clicked.");
    }

}
