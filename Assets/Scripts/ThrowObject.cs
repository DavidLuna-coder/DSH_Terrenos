using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThrowObject : MonoBehaviour
{
    [Header("References")]
    public Transform cam;
    public Transform attackPoint;
    public GameObject objectToThrow;
    //public AudioSource audioSource;
    

    [Header("Settings")]
    public int totalThrows;
    public float throwCooldown;

    [Header("Throwing")]
    public KeyCode throwKey;
    public float throwForce;
    public float throwUpwardForce;

    public bool canThrow;
    void Start()
    {
        canThrow = true;
        //audioSource=GetComponent<AudioSource>();
       // ProjectileAddon.onImpact+=ExplosionSound;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(throwKey) || !canThrow) return;

        Throw();
        

    }
    private void Throw()
    {
        canThrow = false;

        //Instantiate
        GameObject projectile = Instantiate(objectToThrow, attackPoint.position, cam.rotation);

        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        //Calculate direction
        Vector3 forceDirection = cam.forward;

        if (Physics.Raycast(cam.position, cam.forward, out RaycastHit hit, 500f))
        {
            forceDirection = (hit.point - attackPoint.position).normalized;
        }

        //Add force
        Vector3 forceToAdd = forceDirection * throwForce + transform.up * throwUpwardForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);
        totalThrows --;

        Invoke(nameof(ResetThrow), throwCooldown);
    }

    private void ResetThrow()
    {
        canThrow = true;
    }

    /* void ExplosionSound()
    {
        Debug.Log("entra");
        audioSource.Play();
    }*/
}
