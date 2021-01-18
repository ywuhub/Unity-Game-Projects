using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game configuration data
    const string menuHint = "Type 'menu' to access the main menu.";
    string[] level1Passwords = {"art", "lab", "law", "sir", "way"};
    string[] level2Passwords = {"story", "night", "scene", "depth", "hotel"};
    string[] level3Passwords = {"science", "version", "teacher", "surgery", "cabinet"};

    int setPassword;

    // Game Declarations
    int level;
    string password;
    
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        setPassword = Random.Range(0,4); // Pick a random index to select the password from the respective list
        ShowMainMenu();
    }

    // Show the main menu selection screen
    void ShowMainMenu() {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Terminal Hacker!\n");
        Terminal.WriteLine("Select Game Difficulty:");
        Terminal.WriteLine("Press 1 for Easy.");
        Terminal.WriteLine("Press 2 for Medium.");
        Terminal.WriteLine("Press 3 for Hard.\n");
        Terminal.WriteLine("Enter your selection:");
    }

    // Listen for user input
    void OnUserInput(string input) {
        if (input == "menu") {
            ShowMainMenu();
        } else if (currentScreen == Screen.MainMenu) {
            SelectMenu(input);
        } else if (currentScreen == Screen.Password) {
            CheckPassword(input);
        }
    }

    // Game selection menu
    void SelectMenu(string input) {
        bool isValidLevel = (input == "1" || input == "2" || input == "3");
        if (isValidLevel) {
            level = int.Parse(input);
            GuessPassword();
        } else {
            print("Error: Please choose a valid level.");
            Terminal.WriteLine(menuHint);
        }
    }

    // Start the game for the selected level
    void GuessPassword() {
        currentScreen = Screen.Password;
        
        SelectPassword();

        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your password (hint: " + password.Anagram() + "): ");
    }

    // Select a password for the respetive level
    void SelectPassword() {
        switch (level) {
            case 1:
                password = level1Passwords[setPassword];
                break;
            case 2:
                password = level2Passwords[setPassword];
                break;
            case 3:
                password = level3Passwords[setPassword];
                break;
            default:
                print("Error: Invalid level has been given.");
                break;
        }
    }

    // Check if password is corrent
    void CheckPassword(string input) {
        if (input == password) {
            DisplayWinScreen();
        } else {
            GuessPassword();
        }
    }

    // Show the win screen if user guess password correctly
    void DisplayWinScreen() {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        Terminal.WriteLine(@"
      _
     /(|
    (  :
   __\  \  _____
 (____)  `|
(____)|   |
 (____).__|
  (___)__.|_____
");            
        Terminal.WriteLine("Congratulations! Password Verified.");
        Terminal.WriteLine(menuHint);
    }
}

