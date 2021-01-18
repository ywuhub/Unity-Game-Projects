using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game Declarations
    int level;
    enum Screen { MainMenu, Password, Win};

    // Initial State
    Screen currentScreen = Screen.MainMenu;

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
        // TODO: Handle differently depending on screen state
        if (input == "1") {
            level = 1;
            StartGame();
        } else if (input == "2") {
            level = 2;
            StartGame();
        } else if (input == "3") {
            level = 3;
            StartGame();
        } else if (input == "menu") {
            ShowMainMenu();
        } else {
            print("Error: Please choose a valid level.");
        }
    }

    // Start the game for the selected level
    void StartGame() {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have selected level: " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}

