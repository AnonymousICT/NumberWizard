using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        int guess= 500;

        Debug.Log("this is the new attempt");
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number between " + min + "-" +max);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Up = Higher Down = lower Enter=Correct" );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            Debug.Log("Up arrow key was pressed");

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        Debug.Log("Down arrow key was pressed");
    }
}
