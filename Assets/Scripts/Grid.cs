﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
    public GameObject Cube;
   

    public void CubeSquare()
    {
        for (float x = 0; x < 20; x += 1f)
        {
            for (float y = 0; y < 26; y += 1f)
            {
                Instantiate(Cube, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }
   
    public void Start()
    {
        CubeSquare();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
