using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    // Start is called before the first frame update
    int guess= 500;
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess= 500;
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number between " + min + "-" +max);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Up = Higher Down = lower Enter=Correct" );
        max= max + 1;
        Debug.Log(guess);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            min = guess;
            UpdateGuess();
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            max = guess;
            UpdateGuess();
            Debug.Log(guess);

        }
        
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Neat I guessed your number");
            StartGame();
        }
    }

    void UpdateGuess() 
    {
        guess = (max + min ) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
