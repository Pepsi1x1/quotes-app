using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Soundboard : MonoBehaviour {

    public AudioSource Player;
    public AudioClip[] Clips;

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
        Player.clip = Clips[rand.Next(0, Clips.Length - 1)];
        Player.Play();
    }
}
