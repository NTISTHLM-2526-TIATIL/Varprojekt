using UnityEngine;

public class BulletController : MonoBehaviour
{
  [SerializeField]
  float speed = 10f;

  void Start()
  {
    Destroy(this.gameObject, 5);
  }

  void Update()
  {
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
  }
}
