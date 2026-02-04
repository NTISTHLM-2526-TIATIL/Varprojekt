using UnityEngine;
using UnityEngine.InputSystem;

public class LookController : MonoBehaviour
{
  Vector2 lookInput;
  float xRotation = 0;
  Camera head;

  [SerializeField]
  Vector2 sensitivity = Vector2.one;
  
  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    head = GetComponentInChildren<Camera>();
  }

  void Update()
  {
    xRotation += -lookInput.y * sensitivity.y;
    xRotation = Mathf.Clamp(xRotation, -90, 90);

    head.transform.localEulerAngles = new(
      xRotation, 0, 0
    );

    transform.Rotate(Vector3.up, lookInput.x * sensitivity.x);
  }

  void OnLook(InputValue value)
  {
    lookInput = value.Get<Vector2>();
  }
}
