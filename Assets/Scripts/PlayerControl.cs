using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerControl : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX, movementY;
    public float speed = 3f;
    public TextMeshProUGUI textInput;
    private int count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void OnMove(InputValue movementValue) {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;


    }

    // Update is called once per frame
    void FixedUpdate() {
        //Debug.Log(Time.deltaTime); // Time between the frame
        Vector3 movement = new Vector3(movementX, 0f, movementY);
        rb.AddForce(movement * speed);
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Collectables"))  {
            other.gameObject.SetActive(false);
            count = count + 1;
            // textInput.text = count.toString();
        }
    }
}
