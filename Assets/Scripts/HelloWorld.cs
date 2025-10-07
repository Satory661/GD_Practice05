using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public float jumpForce = 5f; // сила прыжка
    private Rigidbody rb;

    void Start()
    {
        Debug.Log("Hello, GameDev!");
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogWarning("На объекте отсутствует компонент Rigidbody!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb != null)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}