using Unity.VisualScripting;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    [SerializeField] private GameObject playOneShotPrefab;
    public void PlaySound(AudioClip audioClip)
    {
        GameObject soundObject = Instantiate(playOneShotPrefab);
        AudioSource audioSource = soundObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
        Destroy(soundObject,audioClip.length);
    }
}
