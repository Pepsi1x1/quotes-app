using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAnimation : MonoBehaviour {

    public GameObject Dialog;
    Vector3 Initial;
    Vector3 Target;
    RectTransform DialogTransform;

	// Use this for initialization
	void Start () {
        DialogTransform = Dialog.GetComponent<RectTransform>();
        Initial = DialogTransform.anchoredPosition;
        Target = new Vector3(Initial.x, Mathf.Abs(Initial.y) * 2, Initial.z);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void In()
    {
        DialogTransform.anchoredPosition = Target;
    }

    public void Out()
    {
        DialogTransform.anchoredPosition = Initial;
    }
}
