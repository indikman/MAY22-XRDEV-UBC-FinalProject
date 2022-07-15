using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GunInteractable : XRGrabInteractable
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float shootForce = 500;

    private AudioSource audioPlayer;
    [SerializeField] private AudioClip shootClip;

    GameObject tempBullet;

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    void Shoot()
    {
        // Instantiate a bullet
        tempBullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);

        // Apple the force to the bullet
        tempBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shootForce);

        // Play shoot sound
        audioPlayer.PlayOneShot(shootClip);

        // Destroy the bullet after 5 secods
        Destroy(tempBullet, 5);
    }

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);

        Shoot();
    }
}
