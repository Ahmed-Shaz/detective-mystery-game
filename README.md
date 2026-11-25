# Detective Mystery Game

A menu-based C# console game where you play a detective and solve two cases by making decisions during the investigation.

## Screenshots

| Choose a case | Answer questions | Case solved |
|---|---|---|
| ![Case selection](screenshots/case-selection.png) | ![Question](screenshots/question.png) | ![Case solved](screenshots/case-solved.png) |

## Cases

- **A. Stolen Cycle from Backyard**
- **B. Lost Wallet at Railway Station**

Each case starts with a short story and has 10 linked multiple-choice questions (A, B, C, D). Correct choices give you clues (points). Wrong choices can make you fail the case.

## How to play

1. Start the program and enter your name.
2. Choose a case (`A` or `B`).
3. Answer the 10 questions with `A`, `B`, `C` or `D`.
4. See your final result (Case Solved / Case Failed) and the number of clues you collected.
5. Press Enter to return to the menu, or `Z` to exit at any time.

## Features

- Main menu with play and statistics options
- Input validation: a wrong key shows "Please enter a valid option." and the program does not crash
- Results are saved automatically after every game
- Statistics can be viewed from the menu and are kept after closing the program

## How results are stored

Every finished game is added to `Player Activity.txt`, in the same folder where the program runs (`bin/Debug`). The file is created automatically if it does not exist. Each entry stores the date and time, player name, case, result and clues.

If writing to the file fails, an error message is shown. Invalid lines in the file are skipped when statistics are read.

## Project structure

- **Program**: main menu, input handling and main loop
- **Game**: case logic, questions and answers, clue counting
- **Stats service**: adds and lists results
- **File service**: reads, writes and creates the text file
- **Model**: game result (player name, case name, clues)

Game logic is kept separate from file handling.

## How to run

1. Clone or download this repository.
2. Open `Detective Mystery Game.slnx` in Visual Studio (made with Visual Studio Community 2026).
3. Press Start.

## Testing

Tested manually: missing file (created automatically), a full game (result saved), invalid menu options (error message shown), and several saved results (best result shows the highest score).

## Known limitations and ideas

Limitations: console only, no database (text file), no multiplayer, no difficulty levels.

Ideas: difficulty levels, timer, Top 10 ranking, graphical interface, database storage, more cases.

## About

School project for the Programming Basics / C# course, 2026.
Author: Ahmed
