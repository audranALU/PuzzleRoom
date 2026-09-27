
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyPedestal : MonoBehaviour
{
    public HiddenKeyPickup hiddenKey;
    public Transform player;
    public Transform keyPlacementPoint;
    public PuzzleManager puzzleManager;

    // Door that opens when Puzzle 3 is completed
    public DoorController doorController;

    public float interactionDistance = 3f;

    private bool puzzleCompleted = false;

    void Update()
    {
        if (puzzleCompleted ||
            hiddenKey == null ||
            player == null)
            return;

        float distance = Vector3.Distance(
            player.position,
            transform.position
        );

        if (distance <= interactionDistance &&
            hiddenKey.hasKey &&
            Keyboard.current != null &&
            Keyboard.current.eKey.wasPressedThisFrame)
        {
            PlaceKey();
        }
    }

    void PlaceKey()
    {
        puzzleCompleted = true;

        // Position the key on the pedestal
        hiddenKey.transform.SetPositionAndRotation(
            keyPlacementPoint.position,
            keyPlacementPoint.rotation
        );

        // Make the key visible again
        foreach (Renderer keyRenderer in
                 hiddenKey.GetComponentsInChildren<Renderer>())
        {
            keyRenderer.enabled = true;
        }

        Debug.Log("Puzzle 3 Completed!");

        // Update overall puzzle progress
        puzzleManager.PuzzleCompleted();

        // Open Door 3
        doorController.OpenDoor();
    }
}
