using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginButtonScript : MonoBehaviour
{
    public Button signInButton;  // Reference to the Sign In Button

    void Start()
    {
        // Add listener to the button to load the MainPage when clicked
        signInButton.onClick.AddListener(SignIn);
    }

    // This function is called when the Sign In button is clicked
    void SignIn()
    {
        SceneManager.LoadScene("MainPage");
    }
}
