using UnityEngine;
using UnityEngine.InputSystem;

public class TankController : MonoBehaviour
{
  Vector2 move = Vector2.zero;

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
