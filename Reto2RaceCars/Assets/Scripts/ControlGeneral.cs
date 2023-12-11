using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlGeneral : MonoBehaviour
{
    public void CambioEscena(int N_escena){
        SceneManager.LoadScene(N_escena);
    }

    public void StopScene(){
      Time.timeScale=0f;
    }

      public void PlayScene(){
      Time.timeScale=1f;
    }


    

    public void quitGame(){
      #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
      #endif
      Application.Quit();
   }
}
