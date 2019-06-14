/*
  probeersels: 
  //EndScreen.SetActive(true);
            //endScreen.SetActive(true); bij scorescript
   public gameobject en .setactive
   verschillende menus en buttonlayouts
   autoreset
 */
using UnityEngine;

public class eindMuisTest : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;
    

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print (currentTime);

        if (currentTime < 0)
            {
            // public void Quit()
            { Debug.Log("rq");
                Application.Quit();
            }
        }



    }





}
