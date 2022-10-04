using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BurgerManager : MonoBehaviour
{
    public GameObject[] burgers;
    
    public Transform[] transforms;

    public int[] answer;
    public int index = 0;

    public void Manager()
    {
        if (index == 7)
        {
            index = 0;
        }   
    }
    public void Quiz(int number)
    {
        
    }


    public void UpBurger()
    {
        Instantiate(burgers[0], transforms[index].position, transforms[index].rotation);
        Quiz(1);
        
        index++;

        Manager();
    }

    public void Tomato()
    {
        Instantiate(burgers[1], transforms[index].position, transforms[index].rotation);
        index++;

        if (index == 7)
            index = 0;
    }

    public void Lettuce()
    {
        Instantiate(burgers[2], transforms[index].position, transforms[index].rotation);
        index++;

        if (index == 7)
            index = 0;
    }
    public void Onion()
    {
        Instantiate(burgers[3], transforms[index].position, transforms[index].rotation);
        index++;

        if (index == 7)
            index = 0;
    }
    public void Patty()
    {
        Instantiate(burgers[4], transforms[index].position, transforms[index].rotation);
        index++;

        if (index == 7)
            index = 0;
    }
    public void Cheeze()
    {
        Instantiate(burgers[5], transforms[index].position, transforms[index].rotation);
        index++;

        if (index == 7)
            index = 0;
    }
    public void DownBurger()
    {
        Instantiate(burgers[6], transforms[index].position, transforms[index].rotation);
        index++;

        if (index == 7)
            index = 0;
    }

}
