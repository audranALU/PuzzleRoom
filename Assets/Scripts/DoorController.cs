using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Vector3 openRotation;
    public float openSpeed = 2f;

    private Quaternion closedRotation;
    private Quaternion targetRotation;
    private bool isOpening = false;

    void Start()
    {
        closedRotation = transform.localRotation;
        targetRotation = Quaternion.Euler(openRotation);
    }

    void Update()
    {
        if (isOpening)
        {
            transform.localRotation = Quaternion.Lerp(
                transform.localRotation,
                targetRotation,
                Time.deltaTime * openSpeed
            );
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
        Debug.Log("Door opening!");
    }
}