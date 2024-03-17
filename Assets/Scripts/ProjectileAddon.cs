using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileAddon : MonoBehaviour
{
    /*public delegate void onHit();
    public static event onHit onImpact;*/
    [SerializeField] GameObject explode;

    public float damage=1f;
    private Rigidbody rb;
    private bool targetHit;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
 
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(targetHit) return;

        Debug.Log("Hit " + other.gameObject.name);
        targetHit = true;

       //if(onImpact!=null)onImpact();
       
        
        Instantiate(explode,transform.position,transform.rotation);

        Destroy(this.gameObject);
     
        /*rb.isKinematic = true;

        transform.SetParent(other.transform);*/
    }


    private void OnTriggerEnter(Collider other)
    {

        if(targetHit) return;

        Debug.Log("Hit " + other.gameObject.name);
        targetHit = true;

        
        other.SendMessage("hited",damage, SendMessageOptions.DontRequireReceiver );
        Instantiate(explode,transform.position,transform.rotation);

        Destroy(this.gameObject);


    }
}
