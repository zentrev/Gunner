﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : Singleton<LevelCreator>
{
    [SerializeField] GameObject[] canyonBits;

    public GameObject[] CanyonBits { get => canyonBits; set => canyonBits = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
