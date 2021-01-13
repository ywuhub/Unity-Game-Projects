using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("Welcome to my Anagram Solver!\n");
        Terminal.WriteLine("Select Game Difficulty:");
        Terminal.WriteLine("Press 1 for Easy.");
        Terminal.WriteLine("Press 2 for Medium.");
        Terminal.WriteLine("Press 3 for Hard.\n");
        Terminal.WriteLine("Enter your selection:");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
