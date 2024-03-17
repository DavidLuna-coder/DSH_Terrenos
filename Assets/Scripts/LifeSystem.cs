using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LifeSystem : MonoBehaviour
{
    public float life=5f;
    public float maxlife=5f;

    public UnityEvent tookHit;
    public UnityEvent Dead;
   void hited(float damage)
   {
        //Debug.Log("Entra con daño:"+ damage);
        life-=damage;
        tookHit.Invoke();
        if(life<=0)
        {
            Dead.Invoke();
        }
   }
}
