using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // loads the game scene


    }
    /**
    * Description: quits the application when the quit button is pressed
    * Pre-condition: the application must be running and the quit button must be active
    * Post-condition: the application will quit
    * @param none
    * @return none
    */
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit(); //quits the application
    }




}
