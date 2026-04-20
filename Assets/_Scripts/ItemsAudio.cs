using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class ItemsAudio : MonoBehaviour
{
    private AudioSource m_audioSource;
    [SerializeField] private AudioClip m_audioClip;
    private void Awake()
    {
        m_audioSource = GetComponent<AudioSource>();
        m_audioSource.playOnAwake = false;
        m_audioSource.volume = 0.2f;
        m_audioSource.clip = m_audioClip;
    }
    
    public void PlaySound()
    {
        m_audioSource.Play();
    }

    public void PlaySoundSeparate()
    {
        AudioSource.PlayClipAtPoint(m_audioClip,transform.position, 0.2f);
    }
}