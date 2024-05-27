using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    [SerializeField]AudioSource prepareMusic;
    [SerializeField]AudioSource sellMusic;
    [SerializeField] Slider audioSlider;
    private void Update()
    {
        prepareMusic.volume=audioSlider.value;
        sellMusic.volume=audioSlider.value;
    }

    private void Awake()
    {
        audioSlider.maxValue=1;
        audioSlider.minValue=0;
        audioSlider.value=audioSlider.maxValue;
    }
}
