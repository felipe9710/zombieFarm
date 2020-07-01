using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField]
    Text killCounter;
    [HideInInspector]
    public int numero;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateKillCounter()
    {
        killCounter.text = numero.ToString();
    }

    public void Winning()
    {
        if (numero == 6)
        {
            SceneManager.LoadScene("Win", LoadSceneMode.Additive);
        }
    }
}
