using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonido : MonoBehaviour
{
    public void MuteAllSound()
    {
        AudioListener.volume = 0;
    }

    public void UnMuteAllSound()
    {
        AudioListener.volume = 1;
    }

}