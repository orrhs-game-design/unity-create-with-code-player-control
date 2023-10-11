using UnityEngine;

public class PlayerControllerWithReverseInput : MonoBehaviour
{
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float forwardInput;
    public bool isDriving = false;
    public int score = 0;

    // Initialize variables
    private float forwardSpeed = 20.0f;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * (Time.deltaTime * forwardSpeed * forwardInput));
        // Rotates the car based on horizontal input
        if (Input.GetKey(KeyCode.S) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            horizontalInput *= -1;
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
        else
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
    }
}


// theorizing that the camera positioning happens before 
// the vehicle movement (so the camera moves to the vehicle's 
// old position + the offset and then the vehicle updates its position).
// This means that if the frame rate is inconsistent the camera 
// position will jitter. There appear to be at least two fixes, 
// 1) use LateUpdate() instead of Update() to set the camera position in
// FollowPlayer.cs, this guarantees that the camera position will be
// updated after the vehicle position; 
// 2) use FixedUpdate() instead of Update() in both PlayerController.cs 
// and FollowPlayer.cs, this ensures that the update rate is constant.