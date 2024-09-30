using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 100;
    int min = 1;
    int guess;
    
    // Start is called before the first frame update
    void Start()
    {
        guess = Random.Range(min,max+1);
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            Lower();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Higher();
        }
        if(Input.GetKeyDown(KeyCode.Return)){
            Finish();
        }
    }
    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number in your head, but don't tell me!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        NextGuess();
    }

    void NextGuess()
    {
        Debug.Log("Is the number higher or lower than " + guess + "?");
        Debug.Log("Press Up = Higher, Press Down = Lower, Press Enter = Correct");
    }
    void Higher()
    {
        min = guess;
        guess = Random.Range(min, max+1);
        NextGuess();
    }

    void Lower()
    {
        max = guess;
        guess = Random.Range(min, max+1);
        NextGuess();
    }

    void Finish()
    {
        Debug.Log("Final number: " + guess + "!");
    }
}
