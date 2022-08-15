using UnityEngine;

public class AudioPlayer : SingletonMonoBehaviour<AudioPlayer>
{
    #region Variables

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _badItemAudioClip;
    [SerializeField] private AudioClip _GoodItemAudioAudioClip;
    [SerializeField] private AudioClip _winAudioClip;
    [SerializeField] private AudioClip _gameOverAudioClip;

    #endregion


    #region Public Methods

    public void PlaySound(AudioClip audioClip)
    {
        if (audioClip == null)
            return;
        
        _audioSource.PlayOneShot(audioClip);
    }

    public void BadItemAudioClip()
    {
        PlaySound(_badItemAudioClip);
    }
    public void GoodItemAudioClip()
    {
        PlaySound(_GoodItemAudioAudioClip);
    }

    public void AddWinAudioClip()
    {
        PlaySound(_winAudioClip);
    }
    
    public void AddGameOverAudioClip()
    {
        PlaySound(_gameOverAudioClip);
    }

    #endregion

    
}