
using UnityEngine;

public class FinalLockPuzzle : MonoBehaviour
{
    public PuzzleManager puzzleManager;
    public DoorController finalDoor;

    // Assign FinalClueBoard's Mesh Renderer.
    public Renderer clueBoardRenderer;

    // 0 = Red, 1 = Green, 2 = Blue
    private int[] correctSequence = { 1, 2, 0 };

    private int currentStep = 0;
    private bool puzzleCompleted = false;
    private Color originalColor;

    void Start()
    {
        if (clueBoardRenderer != null)
            originalColor = clueBoardRenderer.material.color;
    }

    public void PressButton(int buttonID)
    {
        if (puzzleCompleted)
            return;

        if (puzzleManager.completedPuzzles != 4)
        {
            Debug.Log("Complete previous puzzles first!");
            return;
        }

        if (buttonID == correctSequence[currentStep])
        {
            currentStep++;

            if (clueBoardRenderer != null)
                clueBoardRenderer.material.color = originalColor;

            Debug.Log("Correct final button!");

            if (currentStep == correctSequence.Length)
            {
                puzzleCompleted = true;

                if (clueBoardRenderer != null)
                    clueBoardRenderer.material.color = Color.green;

                puzzleManager.PuzzleCompleted();

                Debug.Log("All puzzles completed! Exit unlocked!");

                if (finalDoor != null)
                    finalDoor.OpenDoor();
            }
        }
        else
        {
            currentStep = 0;

            if (clueBoardRenderer != null)
                clueBoardRenderer.material.color = Color.red;

            Debug.Log("Wrong sequence! Final lock reset.");
        }
    }
}
