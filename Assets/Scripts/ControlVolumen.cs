using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVolumen : MonoBehaviour
{
    [SerializeField] Slider nivelVolumen;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicaVolumen"))
        {
            PlayerPrefs.SetFloat("musicaVoluem", 1);
            Load();
        } else
        {
            Load();
        }
    }

    public void CambiarVoluem()
    {
        AudioListener.volume = nivelVolumen.value;
        Save();
    }

    private void Load()
    {
        nivelVolumen.value = PlayerPrefs.GetFloat("musicaVolumen");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicaVolumen", nivelVolumen.value);
    }
}
