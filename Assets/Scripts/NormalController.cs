using UnityEngine;
using UnityEngine.InputSystem;

public class NormalController : MonoBehaviour
{
  Vector2 move = Vector2.zero;

  [SerializeField]
  float walkingSpeed = 1.4f;

  void Update()
  {
    Vector3 mv = Camera.main.transform.forward * move.y
              + Camera.main.transform.right * move.x;

    mv.y = 0;
    mv.Normalize();


    transform.Translate(mv * Time.deltaTime * walkingSpeed);

    GameObject model = transform.GetChild(0).gameObject;

    if (mv.magnitude > 0.1f)
    {
      model.transform.forward = mv;
    }
  }

  public void OnMove(InputValue value)
  {
    Animator anim = GetComponentInChildren<Animator>();
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
}
