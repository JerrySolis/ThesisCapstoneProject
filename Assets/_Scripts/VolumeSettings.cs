/*

Author: JERRY B SOLIS

Note! This software sets is for the settings of audio using independent mixer for each sound

*/



using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider bgMusicSlider;
    [SerializeField] Slider fxSoundSlider;
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;


    const string MIXER_BGmusic = "bgMusic";
    const string MIXER_FXsound = "fxSound";

    private bool muted = false;


    void Start()
    {
        //when user change the value of slider and setting its value to listener
        bgMusicSlider.onValueChanged.AddListener(SetMusicVolume);
        fxSoundSlider.onValueChanged.AddListener(SetSoundVolume);

        //if there has a saved value made by the user then load it if first time changging volume value then save it
        if (!PlayerPrefs.HasKey("Music Volume Slider"))
        {
            PlayerPrefs.SetFloat("Music Volume Slider", 1);
            Load();
        }
        else if (!PlayerPrefs.HasKey("Sound effects volume slider"))
        {
            PlayerPrefs.SetFloat("Sound effects volume slider", 1);
            Load();
        }
        else
        {
            Load();
        }
      
       // Cheking mute button if there is no set of data
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
         UpdateButtonIcon();
        Save();
        AudioListener.pause = muted;
        
    }
        
        //loading and saving user prefs
       public void Load()
        {
            bgMusicSlider.value = PlayerPrefs.GetFloat("Music Volume Slider");
            fxSoundSlider.value = PlayerPrefs.GetFloat("Sound effects volume slider");
            //Retrieve mute data and save it in integer
            muted = PlayerPrefs.GetInt("muted") == 1;
        }

        public void Save()
        {
            PlayerPrefs.SetFloat("Music Volume Slider", bgMusicSlider.value);
            PlayerPrefs.SetFloat("Sound effects volume slider", fxSoundSlider.value);
            //Evaluates Bool type to convert into float
             PlayerPrefs.SetInt("muted", muted ? 1 : 0);
        }


     

        
            public void OnButtonPress()
            {
                if (muted == false)
                {
                    muted = true;
                    AudioListener.pause = true;

                }
                else
                {
                    muted = false;
                    AudioListener.pause = false;
                }
                Save();
                UpdateButtonIcon();
            }

            private void UpdateButtonIcon()
            {
                if (muted == true)
                {
                    soundOnIcon.enabled = false;
                    soundOffIcon.enabled = true;
                }
                else
                {


                    soundOnIcon.enabled = true;
                    soundOffIcon.enabled = false;
                }
            }







          //Connecting the value of slider to mixer group
        void SetMusicVolume(float value)
        {
            mixer.SetFloat(MIXER_BGmusic, value);
      
        }
        void SetSoundVolume(float value)
        {
            mixer.SetFloat(MIXER_FXsound, value);
   
        }
    }


