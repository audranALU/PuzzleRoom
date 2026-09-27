using UnityEngine;

public class SymbolPuzzle : MonoBehaviour
{
    public Transform symbol1;
    public Transform symbol2;
    public Transform symbol3;

    public PuzzleManager puzzleManager;
    public DoorController doorController;

    private bool puzzleCompleted = false;

    public void CheckPuzzle()
    {
        if (puzzleCompleted)
            return;

        float rotation1 = symbol1.localEulerAngles.z;
        float rotation2 = symbol2.localEulerAngles.z;
        float rotation3 = symbol3.localEulerAngles.z;

        // Correct rotations
        if (Mathf.Abs(Mathf.DeltaAngle(rotation1, 90f)) < 5f &&
            Mathf.Abs(Mathf.DeltaAngle(rotation2, 180f)) < 5f &&
            Mathf.Abs(Mathf.DeltaAngle(rotation3, 270f)) < 5f)
        {
            puzzleCompleted = true;

            Debug.Log("Puzzle 2 Completed!");

            // Update overall progress
            puzzleManager.PuzzleCompleted();

            // Open Door 2
            doorController.OpenDoor();
        }
        else
        {
            Debug.Log("Symbols are not correctly aligned.");
        }
    }
}