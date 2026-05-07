Animal Matching Game
A cross-platform memory puzzle application built using .NET MAUI and C#. This project is inspired by the "Head First C#" curriculum, focusing on event-driven programming, UI state management, and algorithmic randomization.

🚀 Features
Dynamic Grid Initialization: Utilizes a FlexLayout with wrapped content to create a responsive 4x4 game board.

Randomized Shuffling: Implements a "Pick and Remove" algorithm using Random.Shared to ensure a unique emoji distribution every game.

State Management: Toggles visibility between the "Play Again" launcher and the active game board to guide user flow.

Clean UI: Custom-styled buttons with consistent dimensions and high-visibility emojis for a better user experience.

🛠️ Technical Stack
Framework: .NET MAUI (Multi-platform App UI)

Language: C# 12.0

Markup: XAML

Core Concepts: LINQ (OfType<T>), List Manipulation, Event Handling, and View-Model interactions.

📂 Code Structure
XAML (View)
The UI uses a VerticalStackLayout to house the game header (Timer and Reset) and a FlexLayout for the animal buttons. Each button is pre-styled and wired to a shared Button_Clicked event handler.

C# (Logic)
The logic focuses on a clean reset-and-play cycle:

Reset: Re-populates the emoji pool.

Distribute: Iterates through the Children collection of the layout, filtering specifically for Button types.

Shuffle: Assigns random emojis and removes them from the pool to ensure perfect pairs.

🚦 Getting Started
Prerequisites: Visual Studio 2022 with the ".NET Multi-platform App UI development" workload installed.

Clone: Open the project folder in Visual Studio.

Run: Select your target platform (Windows, Android, or iOS) and press F5.

Next Steps for the Project:
[ ] Implement the Button_Clicked comparison logic.

[ ] Integrate a IDispatcherTimer to track the "Time Elapsed" label.

[ ] Add a "Game Over" alert when all pairs are matched.