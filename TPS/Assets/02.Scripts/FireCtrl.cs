using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public ParticleSystem cartridge;
    private ParticleSystem muzzleFlash;
    public Transform firePos;

    void Start()
    {
        muzzleFlash = firePos.GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        Instantiate(bullet,firePos.position,firePos.rotation);
        cartridge.Play();
        muzzleFlash.Play();
    }
}
