using UnityEngine;

public class GazeController : MonoBehaviour
{
  Camera head;

  void Start()
  {
    head = GetComponentInChildren<Camera>();
  }

  void OnInteract()
  {
    RaycastHit hit;

    if (Physics.Raycast(
      head.transform.position,
      head.transform.forward,
      out hit, 1
    ))
    {
      // print(hit.transform.name);
      hit.transform.SendMessage("Press",
      SendMessageOptions.DontRequireReceiver);
    }
  }
}
