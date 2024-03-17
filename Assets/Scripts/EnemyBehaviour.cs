using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : MonoBehaviour
{
    private float remainingLife;
    public Image LifeBar;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public void tookHit()
    {
        Debug.Log("TOCADO");
        remainingLife=GetComponent<LifeSystem>().life/GetComponent<LifeSystem>().maxlife;
        //Debug.Log(remainingLife);
        LifeBar.transform.localScale=new Vector3(remainingLife,1,1);

    }


    public void Dead()
    {
        Debug.Log("Morido");
        Destroy(gameObject);
    }
}
