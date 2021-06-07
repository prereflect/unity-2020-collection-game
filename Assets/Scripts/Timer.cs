using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;

    [SerializeField] private float CountDown = 0;

    void Start()
    {
        CountDown = MaxTime;
    }
    void Update()
    {
        CountDown -= Time.deltaTime;

        if (CountDown <= 0)
        {
            Coin.CoinCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
