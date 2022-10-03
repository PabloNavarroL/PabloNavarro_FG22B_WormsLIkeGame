using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    
    public UnitHealth playerHealth = new UnitHealth(100, 100);

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
            Debug.Log(playerHealth.Health);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(30); 
            Debug.Log(playerHealth.Health);
        }

        if (playerHealth.Health <= 0)
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
                Debug.Log(playerHealth.Health);
            }
        
    }


    private void PlayerTakeDmg(int Dmg)
    {
        playerHealth.DmgUnit(Dmg);
    }

    private void PlayerHeal(int Heal)
    {
        playerHealth.HealUnit(Heal);
    }
}
