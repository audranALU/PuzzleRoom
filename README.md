# Puzzle Room: Interactive Escape Challenge

## Game Concept
Puzzle Room is a first-person 3D escape-room game built in Unity. Players explore a series of connected rooms, interpret visual clues, and solve five puzzles to unlock doors and reach the final exit. An on-screen counter tracks progress from **0/5** to **5/5**. After solving every puzzle, players escape through the final door to see the victory screen.

## Puzzle Tasks
1. **Color Sequence:** Follow the visual clue and activate the colored buttons in the order **Blue → Green → Red** to open Door 1.
2. **Symbol Alignment:** Rotate three symbols into their correct orientations (**90°, 180°, and 270°**) to open Door 2.
3. **Hidden Key:** Find and collect a hidden key, then place it on its pedestal to open Door 3.
4. **Switch Sequence:** Use the color clue to activate the switches in the order **Blue → Red → Green** (Switch 2 → Switch 1 → Switch 3). A wrong sequence resets the puzzle.
5. **Final Security Lock:** After completing the first four puzzles, activate the final buttons in the order **Green → Blue → Red**. This unlocks the final exit door. Walk through the exit to win.

## Controls
| Control | Action |
| --- | --- |
| Mouse | Look around and aim at objects |
| Movement keys | Move using the first-person controller (check its configured key bindings) |
| Mouse click | Activate Puzzle 1's color buttons |
| `1`, `2`, `3` | Rotate the corresponding symbols in Puzzle 2 |
| `E` | Pick up and place the key; activate switches and final-lock buttons while looking at them |

## Asset Sources
- **Easy Peasy First Person Controller** — first-person movement: [Add exact download / Asset Store URL]
- **Stylized Hand Painted Dungeon (Free)** — environment assets: [Add exact download / Asset Store URL]
- **Rust Key** — key model: [Add exact download / Asset Store URL]
- **TextMesh Pro** — progress and victory UI: https://docs.unity3d.com/Packages/com.unity.textmeshpro@latest
- **Unity / Universal Render Pipeline (URP)** — game engine and rendering: https://unity.com/ and https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest

> Before submitting, replace the three asset-link placeholders with the URLs of the exact packages you imported. Credit any additional imported models, textures, sounds, or fonts used in your final scene.

## How to Play
Start the game and explore the room. Observe each puzzle's clue, solve the challenges, and follow the newly opened doors. The progress counter updates as you complete puzzles. Wrong sequences in the switch and final-lock puzzles reset those attempts. Solve all five puzzles and pass through the final exit to display the victory screen.
