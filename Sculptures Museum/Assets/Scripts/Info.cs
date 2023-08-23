using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class Info : MonoBehaviour {
 
	public bool isImgOn;
	public Image info;
 
	void Start () {
		info.enabled = false;
		isImgOn = false;
	}
 
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit)){

			//Visible only on Scene Mode
			Debug.DrawLine(ray.origin, hit.point, Color.red, 2.5f);

			if (hit.transform.name == "infoTile" && Input.GetKeyDown ("i")){

				if (isImgOn == true) {
					info.enabled = false;
					isImgOn = false;
				}

				else {
					info.enabled = true;
					isImgOn = true;
				}
			}
		}
	}
}