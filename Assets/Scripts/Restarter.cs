using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
        public void Restart()
    {
        SceneManager.LoadScene("zombieFarm", LoadSceneMode.Additive);
    }
}

