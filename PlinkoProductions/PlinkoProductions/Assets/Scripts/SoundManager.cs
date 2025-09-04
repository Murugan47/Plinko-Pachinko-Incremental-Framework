using UnityEngine;
using UnityEngine.Rendering;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField] private AudioSource bounceSoundSource;
    [SerializeField] private AudioSource spawnSoundSource;
    [SerializeField] private AudioSource scoreSoundSource;
    [SerializeField] private AudioSource menuSoundSource;
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SpawnSoundEffect(AudioClip audioclip, Transform spawnTransform, float volume)
    {
        //Spawn in the gameobject
        AudioSource audioSource = Instantiate(spawnSoundSource, spawnTransform.position, Quaternion.identity);

        //Assign the sound
        audioSource.clip = audioclip;

        //Control the volume of the sound
        audioSource.volume = volume;

        //Play the sound effect
        audioSource.Play();

        //Get length of the sound effect
        float clipLength = audioSource.clip.length;

        //Delete the gameobject
        Destroy(audioSource.gameObject, clipLength);

    }

    public void BounceSoundEffect(AudioClip[] audioclip, Transform spawnTransform, float volume)
    {

        //Random Number Getter
        int randomNumber = Random.Range(0,audioclip.Length);

        //Spawn in the gameobject
        AudioSource audioSource = Instantiate(bounceSoundSource, spawnTransform.position, Quaternion.identity);

        //Assign the sound
        audioSource.clip = audioclip[randomNumber];

        //Control the volume of the sound
        audioSource.volume = volume;

        //Play the sound effect
        audioSource.Play();

        //Get length of the sound effect
        float clipLength = audioSource.clip.length;

        //Delete the gameobject
        Destroy(audioSource.gameObject, clipLength);

    }

    public void ScoreSoundEffect(AudioClip audioclip, Transform spawnTransform, float volume)
    {
        //Spawn in the gameobject
        AudioSource audioSource = Instantiate(scoreSoundSource, spawnTransform.position, Quaternion.identity);

        //Assign the sound
        audioSource.clip = audioclip;

        //Control the volume of the sound
        audioSource.volume = volume;

        //Play the sound effect
        audioSource.Play();

        //Get length of the sound effect
        float clipLength = audioSource.clip.length;

        //Delete the gameobject
        Destroy(audioSource.gameObject, clipLength);

    }

    public void MenuSoundEffect(AudioClip audioclip, Transform spawnTransform, float volume)
    {
        //Spawn in the gameobject
        AudioSource audioSource = Instantiate(menuSoundSource, spawnTransform.position, Quaternion.identity);

        //Assign the sound
        audioSource.clip = audioclip;

        //Control the volume of the sound
        audioSource.volume = volume;

        //Play the sound effect
        audioSource.Play();

        //Get length of the sound effect
        float clipLength = audioSource.clip.length;

        //Delete the gameobject
        Destroy(audioSource.gameObject, clipLength);

    }

}
