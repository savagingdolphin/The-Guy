using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guy : MonoBehaviour
{
    [SerializeField] string myName = "Mikey";
    [SerializeField] ParticleSystem explosion = default;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log("Hello " + myName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Explode();
        }
    }

    private void Explode()
    {
        audioSource.Play();
        explosion.Play();
    }

}
