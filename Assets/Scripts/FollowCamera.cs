using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField]
  GameObject target;

  void Update()
  {
    transform.LookAt(target.transform);
  }
}
