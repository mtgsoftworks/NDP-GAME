
# NDP GAME

## Project Description

**NDP_GAME** is a minefield game where the player needs to navigate through a grid of hidden traps without stepping on them. The goal is to earn points by selecting safe tiles while avoiding hidden traps. When the player steps on a trap, the game ends, and they are given the option to restart.

## How to Play

1. **Objective**: Select safe tiles to score points and avoid traps hidden within the grid.
2. **Grid Setup**: A grid of buttons is created, with a certain number containing traps (indicated as "mines").
3. **Scoring**:
   - Players earn points for selecting safe tiles.
   - The score calculation considers remaining lives and the time elapsed.
4. **Game End**:
   - If a trap is triggered, the game reveals all traps, changing colors for visual feedback (red for traps and green for safe tiles).
   - The player is then prompted to restart the game.

## Features

- **Random Trap Placement**: Each round, traps are placed randomly within the grid.
- **Time Tracking**: The game tracks the time spent and includes it in the final score calculation.
- **Customizable Difficulty**: The game can be adjusted for different grid sizes and trap counts by modifying the `TuzakDoldur` function parameters.
- **Random Trap Images**: Different images are displayed for each trap when activated.

## Libraries Used

This project is developed using **C#** with **Windows Forms** for the graphical user interface.

### Core Libraries and Components

- `System.Windows.Forms`: Provides Windows Forms UI components like buttons, labels, and panels.
- `System.Drawing`: Used for graphical elements like setting colors and images for buttons.
- `System.ComponentModel`: Handles component interactions in the form.
- `System.Linq`: Provides LINQ (Language-Integrated Query) functions for collection handling, such as checking for trap locations.
- `System.Timers`: Manages the game's timer, which tracks elapsed time for scoring.

### Additional Resources

- **Resources** (Images): Custom images for traps are stored in `Properties.Resources` and are displayed based on random selection when a trap is triggered.

## Code Structure

- **Form1_Load**: Initializes the game interface, labels, and starts the timer.
- **TuzakDoldur(int mines, int size)**: Sets up the grid layout and randomly places mines in certain positions.
- **Button Click Event**: Checks if a clicked button contains a trap. If so, the game ends. If not, the player earns points.
- **OyunBitir()**: Ends the game, reveals trap locations, and asks the player if they want to restart.
- **Timer Tick Event**: Increases the elapsed time and updates the score continuously.

## Getting Started

1. **Setup**: Clone or download the project, and open it in Visual Studio.
2. **Run**: Build and run the application.
3. **Play**: Use the grid buttons to navigate, and try to avoid the hidden traps!
