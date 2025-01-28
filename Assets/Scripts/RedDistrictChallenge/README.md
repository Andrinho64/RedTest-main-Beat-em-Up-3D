# Red District Challenge

## Unity Version
This project was developed using Unity 6000.0.25f1 LTS.

## Project Overview
The Red District Challenge is a 3D beat 'em up game prototype where players can control a character to perform basic combo attacks and a special attack with a cooldown. The game features a user interface (UI) that displays an energy bar for the special attack and provides feedback for user interactions.

## Project Structure
- **Assets/**
  - **Animations/CharacterAnimations/**: Contains animation files for character movements and attacks.
  - **Audio/SFX/**: Contains sound effect files for character actions.
  - **Audio/UI/**: Contains sound files for UI interactions.
  - **Prefabs/Character/**: Prefab for the player character.
  - **Prefabs/Enemy/**: Prefab for the dummy enemy used for testing.
  - **Scenes/MainScene.unity**: Main gameplay scene.
  - **Scripts/**: Contains all the scripts for player movement, attacks, UI management, and input handling.
  - **UI/**: Contains UI elements for the energy bar and buttons.

## How to Run the Project
1. Open the project in Unity 6000.0.25f1 LTS.
2. Load the scene located at `Assets/Scenes/MainScene.unity`.
3. Press the Play button to start the game.

## Additional Notes
- Ensure that all audio files are correctly linked to their respective actions in the scripts.
- Animations should be set up in the Animator component of the player prefab.
- The UI elements should be properly configured to display the energy bar and feedback messages.

Feel free to explore and modify the project as needed!