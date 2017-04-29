using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummaryDialog : MonoBehaviour {

    public Text Summary;
    public Text Rebuttal;
    public Text Source;

	void Hide()
    {
        Summary.text = string.Empty;
        Rebuttal.text = string.Empty;
        Source.text = string.Empty;
        gameObject.SetActive(false);
    }

    void Show()
    {
        gameObject.SetActive(true);
    }
}
