using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Make sure to include this for the Button class

public class PaymentGatewayButton : MonoBehaviour
{
    private Button PymtButton; // Reference to the Button component
    private string paymentUrl = "https://www.onlinesbi.sbi/"; // Replace with your actual payment URL

    void Start()
    {
        PymtButton = GetComponent<Button>(); // Get the Button component attached to this GameObject

        if (PymtButton != null)
        {
            PymtButton.onClick.AddListener(OpenPaymentGateway); // Add listener to the button's onClick event
        }
        else
        {
            Debug.LogError("Payment button is not assigned or does not have a Button component!");
        }
    }

    void OpenPaymentGateway()
    {
        Application.OpenURL(paymentUrl); // Open the payment URL in the default web browser
    }
}
