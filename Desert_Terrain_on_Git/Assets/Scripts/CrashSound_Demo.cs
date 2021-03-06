﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound_Demo : MonoBehaviour
{

    public AudioClip crashSoft;
    public AudioClip crashHard;
    public AudioClip crashAlt;
    public AudioClip soundFx1;
    public AudioClip soundFx2;
    public AudioClip soundFx3;
    public AudioClip soundFx4;
    public AudioClip soundFx5;
    public AudioClip soundFx6;
    public AudioClip soundFx7;

    // The Answer to Life, The Universe, and Everything is:

    public int lifeUniverseEverything = 42;

    private AudioSource source;

    public float lowPitchRange = .75F;
    public float highPitchRange = 1.25F;
    public float influence_of_magnitude = .01F;
    public float velocity_limit = 15F;




    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter (Collision collide)
    {
        // without the condition: just play clip
        // source.PlayOneShot(crashSoft, 1F);

        source.pitch = Random.Range(lowPitchRange, highPitchRange);
        float hitVol = collide.relativeVelocity.magnitude * influence_of_magnitude;
        if (collide.relativeVelocity.magnitude < velocity_limit)
            source.PlayOneShot(crashSoft, hitVol);
        else
            source.PlayOneShot(crashHard, hitVol);
    }


}
