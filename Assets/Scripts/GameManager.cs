using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public Transform character;
    public List<Transform> possibleCharacters;
    public int whichCharacter;

    [SerializeField] private float timeBetweenTurns;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }

    void Start()
    {
       


        if (character == null && possibleCharacters.Count >= 1)
        {
            character = possibleCharacters[0];
        }
        Swap();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (whichCharacter == 0)
            {
                whichCharacter = possibleCharacters.Count - 1;
            }
            else
            {
                whichCharacter -= 1;
            }
            Swap();

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (whichCharacter == possibleCharacters.Count - 1)
            {
                whichCharacter = 0;
            }
            else
            {
                whichCharacter += 1;
            }
            Swap();
        }



    }

    public void Swap()
    {
        character = possibleCharacters[whichCharacter];
        character.GetComponent<PointClickMovement>().enabled = true;
        character.GetComponent<PointClickMovement>().timeToMove = 0f;
        character.GetComponent<Attack>().enabled = true;


        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if (possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<PointClickMovement>().enabled = false;
            }
        }

        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if (possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<Attack>().enabled = false;
            }
        }

    }

}


