using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control_Scenes : MonoBehaviour
{

    public void cambiarEscena (int index_escena)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(index_escena);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Scene scene = SceneManager.GetActiveScene();
            if (scene.buildIndex == 0)
            {
                cambiarEscena(1);
            }
            if(scene.buildIndex == 1)
            {
                cambiarEscena(2);
            }
           if(scene.buildIndex == 2)
            {
                cambiarEscena(0);
            }
        }
    }
}
