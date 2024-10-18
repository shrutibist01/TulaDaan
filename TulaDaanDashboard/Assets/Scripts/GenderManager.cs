using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderManager : MonoBehaviour
{
	public enum Gender {Male, Female}
	public static Gender SelectedGender {get; private set;}

	public void SetGender(Gender gender) {
		SelectedGender = gender;
		Debug.Log("Selected Gender : " + SelectedGender);
	}
}
