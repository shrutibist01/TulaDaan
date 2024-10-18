

using UnityEngine;
using UnityEngine.UI;

public class WeightInputManager : MonoBehaviour
{
	public InputField EnterWeightInput; // Drag your InputField here in the Inspector

	public void LogWeight()
	{
		if (EnterWeightInput == null)
		{
			Debug.LogError("EnterWeightInput is not assigned!");
			return;
		}

		string input = EnterWeightInput.text;
		float weight;

		if (float.TryParse(input, out weight))
		{
			if (weight > 0)
			{
				Debug.Log("Weight entered: " + weight + " kg");
			}
			else
			{
				Debug.LogError("Error: Weight must be a positive value.");
			}
		}
		else
		{
			Debug.LogError("Error: Invalid input. Please enter a numeric value.");
		}
	}
}

