﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int batterlife = 100;
   
    public int experience = 0;

   public void Objectcollected()
    {
        experience += 1;

    }


    
}