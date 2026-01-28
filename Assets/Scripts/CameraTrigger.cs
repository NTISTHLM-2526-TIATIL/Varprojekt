using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
  [SerializeField]
  Camera cam;

  void OnTriggerEnter(Collider other)
  {
    GameObject[] cameras = GameObject.FindGameObjectsWithTag("MainCamera");

    foreach (GameObject obj in cameras)
    {
      obj.SetActive(false);
    }

    cam.gameObject.SetActive(true);

    print("hej");
  }
}
