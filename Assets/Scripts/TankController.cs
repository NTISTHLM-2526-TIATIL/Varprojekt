using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
  Vector2 move = Vector2.zero;

  [SerializeField]
  float rotationSpeed = 20;

  [SerializeField]
  float walkingSpeed = 1.4f;

  public void Update()
  {
    Vector3 mv = Vector3.forward * walkingSpeed * move.y;
    transform.Translate(mv * Time.deltaTime);

    float angle = rotationSpeed * move.x;
    transform.Rotate(Vector3.up, angle * Time.deltaTime);
  }

  public void OnMove(InputValue value)
  {
    Animator anim = GetComponent<Animator>();
    move = value.Get<Vector2>();
    if (move.magnitude > 0.1f)
    {
      anim.SetBool("moving", true);
    }
    else
    {
      anim.SetBool("moving", false);
    }
  }

  public void OnJump(InputValue value)
  {
    Animator anim = GetComponent<Animator>();
    anim.SetBool("moving", true);
  }
}
