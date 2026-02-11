using UnityEngine;
using UnityEngine.InputSystem;

public class MoveController : MonoBehaviour
{
  [SerializeField]
  float walkSpeed = 2f;

  [SerializeField]
  float jumpForce = 12;

  [SerializeField]
  float gravityMult = 2f;

  Vector2 moveInput;

  CharacterController controller;

  float velocityY = 0;

  void Start()
  {
    controller = GetComponent<CharacterController>();
  }

  void Update()
  {
    // GRAVITY
    velocityY += Physics.gravity.y * gravityMult * Time.deltaTime;

    if (controller.isGrounded && velocityY < 0)
    {
      velocityY = -1;
    }

    // MOVEMENT
    Vector3 movement = transform.forward * moveInput.y
    + transform.right * moveInput.x;

    movement *= walkSpeed;

    movement.y = velocityY;

    controller.Move(movement * Time.deltaTime);
  }

  void OnMove(InputValue value)
  {
    moveInput = value.Get<Vector2>();
  }

  void OnJump(InputValue value)
  {
    if (controller.isGrounded)
    {
      velocityY = jumpForce;
    }
  }
}
