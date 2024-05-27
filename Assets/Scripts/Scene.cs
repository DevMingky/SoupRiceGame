using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void OnClcikStart()
    {
        SceneManager.LoadScene(1);
    }

    public void End()
    {
        SceneManager.LoadScene(0);
    }
}
