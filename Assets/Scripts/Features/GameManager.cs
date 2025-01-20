using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform leftSpawnPoint;
    public Transform rightSpawnPoint;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
}