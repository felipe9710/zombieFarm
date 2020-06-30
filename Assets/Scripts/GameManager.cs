using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();       
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {

            GameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
