using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMudarCena : MonoBehaviour
{
    // Start is called before the first frame update
    public void ScriptMudar()
    {
        SceneManager.LoadScene("Jogo");
    }
    public void Sair()
    {
        Application.Quit();
    }
}
