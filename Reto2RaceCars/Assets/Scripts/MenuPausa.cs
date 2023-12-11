using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPausa : MonoBehaviour
{   
    [SerializeField] private GameObject botonPausa;

    [SerializeField] private GameObject menuPausa;


    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        
        // AudioSource[] audios = FindObjectsOfType<AudioSource>();
        // foreach (AudioSource a in audios)
        // {
        //     a.Pause();
        // }
    }

    public void Reanudar (){
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);

        // AudioSource[] audios = FindObjectsOfType<AudioSource>();
        // foreach (AudioSource a in audios)
        // {
        //     a.Play();
        // }
    }

    public void CambioEscena(int N_escena){
        SceneManager.LoadScene(N_escena);
    }
    
    public void Reiniciar (){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start() {
        
    }


    public void quitGame(){
      #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
      #endif
      Application.Quit();
   }
}
