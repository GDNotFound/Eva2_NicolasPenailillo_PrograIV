using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeToTest()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeToMake()
    {
        SceneManager.LoadScene(0);
    }
}
