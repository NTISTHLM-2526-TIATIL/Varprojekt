using UnityEngine;

public class WeaponsScript : MonoBehaviour
{
  void OnAttack()
  {
    ShotgunController shotgun = GetComponentInChildren<ShotgunController>();

    shotgun.Fire();  
  }
}
