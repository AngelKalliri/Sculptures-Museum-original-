using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Help : MonoBehaviour
{
	public Button button;
	public bool buttonisclicked, isOn;
	public Image img;

	void Start ()
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(ButtonPressed);
		buttonisclicked = false;
		img.enabled = false;
		isOn = false;
	}


	void ButtonPressed()
	{
		buttonisclicked = true;

		if(buttonisclicked)
		{
			if (isOn) 
			{
				img.enabled = false;
				isOn = false;
			}

			else 
			{
				img.enabled = true;
				isOn = true;
			}
		}
	}

	void Update()
	{
		
	}
}