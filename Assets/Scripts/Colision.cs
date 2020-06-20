using UnityEngine;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public player mov;
    public int Health = 3;
    public Text vida;
    void OnCollisionEnter(Collision Info)
    {
        if (Info.collider.tag == "Zombie")
        {
            Debug.Log("ZOMBIE");
            Health = Health - 1;
        }
        if (Health == 3)
        {
            vida.text = "ooo";
        }
        if (Health == 2)
        {
            vida.text = "oo";
        }
        if (Health == 1)
        {
            vida.text = "o";
        }
        if (Health == 0)
        {
            vida.text = " ";
            mov.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}