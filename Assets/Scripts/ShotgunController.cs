using UnityEngine;

public class ShotgunController : MonoBehaviour
{
  [SerializeField]
  GameObject bulletPrefab;

  [SerializeField]
  float timeBetweenShots = 1;
  float timeSinceShot = 0;

  Transform spawnPoint;

  void Start()
  {
    spawnPoint = transform.GetChild(0).transform;
  }

  public void Fire()
  {
    if (timeSinceShot > timeBetweenShots)
    {
      Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
      timeSinceShot = 0;
    }
  }

  void Update()
  {
    timeSinceShot += Time.deltaTime;
    Fire();
  }
}
