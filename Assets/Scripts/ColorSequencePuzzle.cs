using UnityEngine;

public class ColorSequencePuzzle : MonoBehaviour
{
    public int currentStep = 0;

    public PuzzleManager puzzleManager;
    public DoorController doorController;

    // 0 = Blue
    // 1 = Green
    // 2 = Red
    private int[] correctSequence = { 0, 1, 2 };

    public void PressButton(int buttonID)
    {
        // Prevent pressing buttons after the puzzle is completed
        if (currentStep >= correctSequence.Length)
            return;

        // Correct button
        if (buttonID == correctSequence[currentStep])
        {
            currentStep++;

            Debug.Log("Correct!");

            // Puzzle completed
            if (currentStep >= correctSequence.Length)
            {
                Debug.Log("Puzzle 1 Completed!");

                // Update overall progress
                puzzleManager.PuzzleCompleted();

                // Open the door
                doorController.OpenDoor();
            }
        }
        else
        {
            // Wrong button: reset sequence
            currentStep = 0;

            Debug.Log("Wrong! Sequence reset.");
        }
    }
}