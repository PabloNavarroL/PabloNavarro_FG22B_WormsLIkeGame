using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoBehaviour : MonoBehaviour
{

    public UnitHealth playerTwoHealth = new UnitHealth(100, 100);

    [SerializeField] GameObject deathEffect;
    [SerializeField] GameObject player;
    float delay = 2f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDmg(30);
            Debug.Log(playerTwoHealth.Health);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(30);
            Debug.Log(playerTwoHealth.Health);
        }

        if (playerTwoHealth.Health <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy((player), delay);

        }


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Explotion"))
        {
            PlayerTakeDmg(30);
            Debug.Log(playerTwoHealth.Health);
        }

    }


    private void PlayerTakeDmg(int Dmg)
    {
        playerTwoHealth.DmgUnit(Dmg);
    }

    private void PlayerHeal(int Heal)
    {
        playerTwoHealth.HealUnit(Heal);
    }
}

