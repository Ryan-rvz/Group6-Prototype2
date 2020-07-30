using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource death;
    public AudioSource dye;
    public AudioSource eggPickup;

    public void DeathSound()
    {
        death.Play();
    }
    public void DyeSound()
    {
        dye.Play();
    }
    public void EggPickupSound()
    {
        eggPickup.Play();
    }
}
