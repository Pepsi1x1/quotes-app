using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Soundboard : MonoBehaviour {

    public AudioSource Player;
    public SummaryDialog Dialog;
    public Soundbite[] Clips;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    System.Random rand = new System.Random();

    public void RandomSound()
    {
        Player.Stop();
        Soundbite sb = Clips[rand.Next(0, Clips.Length - 1)];
        Player.clip = sb.Clip;

        Dialog.Summary.text = sb.Summary;
        Dialog.Rebuttal.text = sb.Rebuttal;
        Dialog.Source.text = sb.Source;

        Player.Play();
    }
}

[Serializable]
public class Soundbite 
{
    public string Name;
    public AudioClip Clip;
    public string Source;
    public DateTime SourceDate;
    public string Summary;
    public string Rebuttal;
}