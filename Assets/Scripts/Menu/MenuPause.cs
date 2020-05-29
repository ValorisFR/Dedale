﻿using UnityEngine;
using UnityEngine.UI;
using FMOD;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu = null;
    [SerializeField] private GameObject _settings = null;
    [SerializeField] private Slider _sliderMusique = null;
    [SerializeField] private Slider _sliderDialogue = null;
    [SerializeField] private Slider _sliderMouseSensitivity = null;

    public void OnStart()
    {
        _pauseMenu.SetActive(true);
        _settings.SetActive(false);
        //_sliderMusique.value = SoundManager.Instance.InitAudioMixer("Sound Design");
        //_sliderDialogue.value = SoundManager.Instance.InitAudioMixer("Dialogue et voix");
        _sliderMouseSensitivity.value = PlayerManager.Instance.MouseSensitivityMultiplier;
    }

    public void OnChangeVolumeDialogue()
    {
        //SoundManager.Instance.MixerDialogue(_sliderDialogue.value);
    }

    public void OnChangeVolumeMusique()
    {
        //SoundManager.Instance.MixerSoundDesign(_sliderMusique.value);
    }

    public void OnChangeMouseSensitivity()
    {
        PlayerManager.Instance.MouseSensitivityMultiplier = _sliderMouseSensitivity.value;
    }

    public void OnClickContinue()
    {
        _pauseMenu.SetActive(false);
        GameLoopManager.Instance.IsPaused = false;
    }

    public void OnClickOption()
    {
        _pauseMenu.SetActive(false);
        _settings.SetActive(true);
    }

    public void OnClickQuit()
    {
        _pauseMenu.SetActive(false);
        GameManager.Instance.ChangeState(GameManager.MyState.MAINMENU);
    }

    public void OnClickReturn()
    {
        _pauseMenu.SetActive(true);
        _settings.SetActive(false);
    }

    public void OnPressEscape()
    {
        _pauseMenu.SetActive(false);
        _settings.SetActive(false);
    }
}
