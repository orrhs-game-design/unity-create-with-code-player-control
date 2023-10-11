using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f; // float is decimal
    public bool gameOver = false;
    public int score = 0; // int is a whole number
    public string carName = "Ford"; // this is text

    //public float carSpeed = 20.0f;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        // Move the vehicle forward
        // transform.Translate(0, 0, 1);

        // Move the vehicle forward using Vector
        // transform.Translate(Vector3.forward * Time.deltaTime * 20);

        // Move the vehicle forward using a variable for speed
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}

// OTHER VARIABLE TYPE EXAMPLES

// public float age = 10.0f;
// public string make = "Ford";
// public string model = "F150";
// public int year = 2018;
// public bool isNew = true;
