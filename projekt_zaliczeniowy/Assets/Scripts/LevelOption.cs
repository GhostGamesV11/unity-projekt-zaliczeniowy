using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOption : MonoBehaviour
{
    [SerializeField] private int level;

    public void ChooseLevel()
    {
        SceneManager.LoadScene(level);
    }
}