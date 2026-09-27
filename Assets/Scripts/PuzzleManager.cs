
using UnityEngine;
using TMPro;

public class PuzzleManager : MonoBehaviour
{
    public int completedPuzzles = 0;
    public int totalPuzzles = 5;

    // Text displayed on the player's screen
    public TMP_Text progressText;

    void Start()
    {
        UpdateProgressUI();
    }

    public void PuzzleCompleted()
    {
        completedPuzzles++;

        Debug.Log("Puzzle Progress: " +
                  completedPuzzles + " / " + totalPuzzles);

        UpdateProgressUI();
    }

    void UpdateProgressUI()
    {
        if (progressText != null)
        {
            progressText.text = "Puzzle Progress: " +
                                completedPuzzles + " / " +
                                totalPuzzles;
        }
    }
}
