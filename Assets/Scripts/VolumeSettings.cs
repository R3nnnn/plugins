using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer volumeSet;
    [SerializeField] private Slider musicSet;

    public void SetVolume()
    {
        float volume = musicSet.value;
        volumeSet.SetFloat("volume", Mathf.Log10(volume)*20);
    }
}
