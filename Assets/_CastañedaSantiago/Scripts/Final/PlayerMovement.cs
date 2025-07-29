using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveForce = 500f; // Use higher values since force is frame-dependent
    public float maxSpeed = 5f;
    private Vector3 moveInput;
    private Rigidbody rb;

    [Header("Camera")]
    public Transform cameraHolder;
    public float mouseSensitivity = 2f;
    private float verticalLookRotation = 0f;

    [Header("Raycasting")]
    public Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // --- Input ---
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        moveInput = (transform.right * moveX + transform.forward * moveZ).normalized;

        // --- Mouse Look ---
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);

        verticalLookRotation -= mouseY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -85f, 85f);
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0f, 0f);

        // --- Raycast ---
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100f))
            {
                Debug.Log("Raycast hit: " + hit.collider.name + " at " + hit.point);
            }
        }
    }

    void FixedUpdate()
    {
        Vector3 targetVelocity = moveInput * maxSpeed;
        Vector3 velocityChange = targetVelocity - rb.linearVelocity;
        velocityChange.y = 0f; // Keep vertical velocity for gravity/jumping

        rb.AddForce(velocityChange, ForceMode.VelocityChange);
    }
}
