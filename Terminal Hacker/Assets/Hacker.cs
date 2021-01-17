using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // Show the main menu selection screen
    void ShowMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to my Anagram Solver!\n");
        Terminal.WriteLine("Select Game Difficulty:");
        Terminal.WriteLine("Press 1 for Easy.");
        Terminal.WriteLine("Press 2 for Medium.");
        Terminal.WriteLine("Press 3 for Hard.\n");
        Terminal.WriteLine("Enter your selection:");
    }

    // Listen for user input
    void OnUserInput(string input) {
        // Alternative print(input == "1");
        if (input == "1") {
            print("Level 1 Selected.");
        } else if (input == "2") {
            print("Level 2 Selected.");
        } else if (input == "3") {
            print("Level 3 Selected.");
        } else if (input == "menu") {
            ShowMainMenu();
        } else {
            print("Error: Please choose a valid level.");
        }
    }
}
