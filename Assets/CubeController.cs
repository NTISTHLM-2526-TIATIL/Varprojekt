using UnityEngine;

public class CubeController : MonoBehaviour
{
  void Start()
  {
    GameObject[] cylinders = GameObject.FindGameObjectsWithTag("Cyl");

    for (int i = 0; i < cylinders.Length; i++)
    {
      Destroy(cylinders[i]);
    }
  }

  void Update()
  {

  }
}
