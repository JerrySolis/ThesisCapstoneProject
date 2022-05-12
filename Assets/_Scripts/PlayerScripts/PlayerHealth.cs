using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;

    public GameObject LevelFailed, SimulationGermEntered;

    public int Hit_Point = 100;

    private int Max_HitPoint = 100;

    public int HealAmount;

    public Player_HealthBar playerHealth;

    [SerializeField] private AudioSource woundHurtAudiofx;
    public void Damage(int amount)
    {
        woundHurtAudiofx.Play();
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative damage!");
        }
        if (amount > Hit_Point)
        {
            Hit_Point = 0;
        }
        this.Hit_Point -= amount;

        if (Hit_Point <= 0)
        {
            GameManager.Instance.UpdateGameState(GameState.LevelFailed);

        }
    }




    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Heal!");
        }
        this.Hit_Point += amount;

        //Limiting heal amount into maximum Hitpoints 
        bool wouldBeOverMaxHP = Hit_Point + amount > Max_HitPoint;
        if (wouldBeOverMaxHP)
        {
            this.Hit_Point = Max_HitPoint;
        }
        else
        {
            this.Hit_Point += amount;
        }
    }


    private void Awake()
    {
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        playerHealth.SetMaxHealth(Max_HitPoint);
        playerHealth.SetHealth(Hit_Point);
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.SetHealth(Hit_Point);

     

    }
    public void HealPlayer()
    {
        Heal(10);
    }
}
