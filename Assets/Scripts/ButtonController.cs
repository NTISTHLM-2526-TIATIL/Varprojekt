using UnityEngine;

public class ButtonController : MonoBehaviour
{
  [SerializeField]
  GameObject target;

  bool isToggled = false;

  public void Press()
  {
    print("That's very im-PRESS-ive");
    if (isToggled)
    {
      GetComponent<Renderer>().material.color = Color.gray;
      isToggled = false;
      target.SetActive(false);
    }
    else
    {
      GetComponent<Renderer>().material.color = Color.green;
      isToggled = true;
      target.SetActive(true);
    }
    
  }
}
