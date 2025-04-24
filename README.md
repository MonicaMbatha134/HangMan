Hangman Game in C#
A simple, interactive Hangman game built with C#. Play in your terminal and guess the hidden word before you run out of attempts!

Features
-Random word selection from a predefined list
-ASCII art for hangman stages
-Input validation for guesses
-Tracks guessed letters and remaining attempts
-User-friendly terminal interface

Getting Started
Prerequisites
-.NET SDK (version 6.0 or later recommended)
-A terminal or command prompt

How to Play
-The game will display a series of underscores representing the hidden word.
-Enter one letter per guess.
-If the letter is in the word, it will be revealed in its correct position(s).
-If not, a part of the hangman will be drawn.
-You win by guessing all the letters before the hangman is fully drawn.
-You lose if the hangman is completed before you guess the word

Example Gameplay
Word: _ _ _ _ _

Guess a letter: a

Sorry, 'a' is not in the word.

+---+
|   |
O   |
    |
    |
    |
======

Customization
You can add more words to the word list in the code.
Adjust the number of allowed incorrect guesses by modifying the hangman stages.

Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

License
This project is licensed under the MIT License.

Acknowledgements
Inspired by the classic Hangman word game 
ASCII art adapted from asciiart.eu.