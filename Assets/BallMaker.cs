using UnityEngine;

public class BallMaker : MonoBehaviour
{
  [SerializeField]
  GameObject ballPrefab;

  void FixedUpdate()
  {
    Instantiate(ballPrefab, transform.position, Quaternion.identity);
  }
}
