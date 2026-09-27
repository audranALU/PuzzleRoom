
using UnityEngine;

public class ExitVictory : MonoBehaviour
{
    public PuzzleManager puzzleManager;
    public GameObject victoryPanel;

    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasWon)
            return;

        // Check that the player entered the exit.
        if (!other.CompareTag("Player"))
            return;

        // All five puzzles must be completed.
        if (puzzleManager != null &&
            puzzleManager.completedPuzzles == 5)
        {
            hasWon = true;

            if (victoryPanel != null)
                victoryPanel.SetActive(true);

            Debug.Log("YOU ESCAPED! All puzzles completed!");
        }
    }
}
