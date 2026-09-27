
using UnityEngine;

public class SwitchPuzzle : MonoBehaviour
{
    public PuzzleManager puzzleManager;
    public DoorController doorController;

    // Drag SwitchClueBoard here.
    public Renderer clueBoardRenderer;

    private int[] correctSequence = { 2, 1, 3 };
    private int currentStep = 0;
    private bool puzzleCompleted = false;

    private Color originalColor;

    void Start()
    {
        if (clueBoardRenderer != null)
        {
            // Use a separate material instance.
            originalColor =
                clueBoardRenderer.material.color;
        }
    }

    public void ActivateSwitch(int switchID)
    {
        if (puzzleCompleted)
            return;

        if (switchID == correctSequence[currentStep])
        {
            currentStep++;

            if (clueBoardRenderer != null)
                clueBoardRenderer.material.color =
                    originalColor;

            Debug.Log("Correct switch!");

            if (currentStep == correctSequence.Length)
            {
                puzzleCompleted = true;

                if (clueBoardRenderer != null)
                    clueBoardRenderer.material.color =
                        Color.green;

                Debug.Log("Puzzle 4 Completed!");

                puzzleManager.PuzzleCompleted();

                if (doorController != null)
                    doorController.OpenDoor();
            }
        }
        else
        {
            currentStep = 0;

            if (clueBoardRenderer != null)
                clueBoardRenderer.material.color =
                    Color.red;

            Debug.Log("Wrong switch! Sequence reset.");
        }
    }
}
