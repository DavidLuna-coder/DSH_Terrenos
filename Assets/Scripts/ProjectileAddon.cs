using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAddon : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private bool targetHit;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(targetHit) return;

        Debug.Log("Hit " + other.gameObject.name);
        targetHit = true;
        rb.isKinematic = true;

        transform.SetParent(other.transform);
    }
}
