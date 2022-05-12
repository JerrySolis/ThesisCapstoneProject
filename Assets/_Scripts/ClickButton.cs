using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default, _pressed;
    [SerializeField] private AudioClip _audioFX;
    [SerializeField] private AudioSource _audioSource;

    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _pressed;
        _audioSource.PlayOneShot(_audioFX);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
        _audioSource.PlayOneShot(_audioFX);
    }





    //Debug Logs
    public void OnClickedPlay()
    {
        Debug.Log("Play Button Clicked");
    }
    public void OnClickedSetting()
    {
        Debug.Log("Settings Button Clicked");
    }
    public void OnClickedAbout()
    {
        Debug.Log("About Button Clicked");
    }
    public void OnClickedGermData()
    {
        Debug.Log("Germ Data Button Clicked");
    }
    public void OnClickedGameExit()
    {
        Debug.Log("Exit Game Button Clicked");
    }
    public void OnClickedVolumeSettings()
    {
        Debug.Log("Volume Settings Button Clicked");
    }














}
