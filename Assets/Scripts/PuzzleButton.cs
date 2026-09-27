using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    public ColorSequencePuzzle puzzle;
    public int buttonID;

    private void OnMouseDown()
    {
        puzzle.PressButton(buttonID);
    }
}