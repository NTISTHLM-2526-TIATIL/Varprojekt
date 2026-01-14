using UnityEngine;

public class CubeController : MonoBehaviour
{
  void Start()
  {
    GameObject[] cylinders = GameObject.FindGameObjectsWithTag("Cyl");

    // METOD 4: Slump
    for (int i = 0; i < cylinders.Length; i++)
    {
      if (Random.Range(0, 2) == 0)
      {
        Renderer r = cylinders[i].GetComponent<Renderer>();
        r.material.color = new Color(0, 0, 1);
      }
      else
      {
        Renderer r = cylinders[i].GetComponent<Renderer>();
        r.material.color = new Color(1, 0, 0);
      }
    }

    // METOD 3: Varannan
    // for (int i = 0; i < cylinders.Length; i++)
    // {
    //   if (i % 2 == 0)
    //   {
    //     Renderer r = cylinders[i].GetComponent<Renderer>();
    //     r.material.color = new Color(0, 0, 1);
    //   }
    //   else
    //   {
    //     Renderer r = cylinders[i].GetComponent<Renderer>();
    //     r.material.color = new Color(1, 0, 0);
    //   }
    // }

    // METOD 2: Splitta med en if-sats
    // for (int i = 0; i < cylinders.Length; i++)
    // {
    //   if (i < cylinders.Length / 2)
    //   {
    //     Renderer r = cylinders[i].GetComponent<Renderer>();
    //     r.material.color = new Color(0, 0, 1);
    //   }
    //   else
    //   {
    //     Renderer r = cylinders[i].GetComponent<Renderer>();
    //     r.material.color = new Color(1, 0, 0);
    //   }
    // }

    // METOD 1: Två for-loopar
    // for (int i = 0; i < cylinders.Length / 2; i++)
    // {
    //   Renderer r = cylinders[i].GetComponent<Renderer>();
    //   r.material.color = new Color(0, 0, 1);
    // }
    // for (int i = cylinders.Length / 2; i < cylinders.Length; i++)
    // {
    //   Renderer r = cylinders[i].GetComponent<Renderer>();
    //   r.material.color = new Color(1, 0, 0);
    // }
  }

  void Update()
  {

  }
}
