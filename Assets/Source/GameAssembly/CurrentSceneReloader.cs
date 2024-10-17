using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SingletonTask.GameAssembly
{
    public class CurrentSceneReloader : MonoBehaviour
    {
        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.R)) return;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}