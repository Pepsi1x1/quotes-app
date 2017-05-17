using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Soundboard : MonoBehaviour {

    public AudioSource Player;
    public SummaryDialog Dialog;
    public Soundbite[] Clips;

	private int _soundbiteIndex = 0;

	private int SoundbiteIndex {
		get {
			return _soundbiteIndex;
		}
		set {
			_soundbiteIndex = value;
			if (_soundbiteIndex > Clips.Length - 1)
				_soundbiteIndex = 0;
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RandomSound()
    {
        Player.Stop();
        Soundbite sb = Clips[SoundbiteIndex++];
        Player.clip = sb.Clip;

        Dialog.Summary.text = sb.Summary;
        Dialog.Rebuttal.text = sb.Rebuttal;
        Dialog.Source.text = sb.Source;

        Player.Play();
    }
}