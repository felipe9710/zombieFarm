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
            SceneManager.LoadScene("GameOverScreen", LoadSceneMode.Additive);
        }
    }

    /*void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/

}
