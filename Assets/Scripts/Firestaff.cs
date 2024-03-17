using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firestaff : MonoBehaviour
{

    AudioSource audioSource;
       void Start()
    {
        audioSource=GetComponent<AudioSource>();
        
    }

  
    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            audioSource.Play();
            
        }
    }


   
}
