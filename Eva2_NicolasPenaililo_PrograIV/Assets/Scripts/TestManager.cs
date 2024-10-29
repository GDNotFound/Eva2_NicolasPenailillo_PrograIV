using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestManager : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public Image championIcon;
    public Sprite defaultSprite;
    public string selectedChampion;
    public string selectedMusic;
    public AudioSource music;
    
    public void ChangeEverything(int index)
    {
        index = dropdown.value;
        if (index == 1)
        {
            selectedChampion = "Sona";

            string path = selectedChampion;
            Sprite sprite = Resources.Load<Sprite>(path);
            AudioClip clip = Resources.Load<AudioClip>(path);
            if (sprite == null)
            {
                sprite = defaultSprite;
            }
            championIcon.sprite = sprite;
            music.clip = clip;
            music.Play();
        }
        if (index == 2)
        {
            selectedChampion = "Sivir";
            string path = selectedChampion;
            Sprite sprite = Resources.Load<Sprite>(path);
            AudioClip clip = Resources.Load<AudioClip>(path);
            if (sprite == null)
            {
                sprite = defaultSprite;
            }
            championIcon.sprite = sprite;
            music.clip = clip;
            music.Play();
        }
        if (index == 3)
        {
            selectedChampion = "Vel'koz";
            string path = selectedChampion;
            Sprite sprite = Resources.Load<Sprite>(path);
            AudioClip clip = Resources.Load<AudioClip>(path);
            if (sprite == null)
            {
                sprite = defaultSprite;
            }
            championIcon.sprite = sprite;
            music.clip = clip;
            music.Play();
        }
        if (index == 4)
        {
            selectedChampion = "Ornn";
            string path = selectedChampion;
            Sprite sprite = Resources.Load<Sprite>(path);
            AudioClip clip = Resources.Load<AudioClip>(path);
            if (sprite == null)
            {
                sprite = defaultSprite;
            }
            championIcon.sprite = sprite;
            music.clip = clip;
            music.Play();
        }
        if (index == 5)
        {
            selectedChampion = "Pantheon";
            string path = selectedChampion;
            Sprite sprite = Resources.Load<Sprite>(path);
            AudioClip clip = Resources.Load<AudioClip>(path);
            if (sprite == null)
            {
                sprite = defaultSprite;
            }
            championIcon.sprite = sprite;
            music.clip = clip;
            music.Play();
        }
    }
}
