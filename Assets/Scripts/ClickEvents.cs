using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvents : MonoBehaviour
{

    private List<string> items = new List<string>();
    private int index;
    private int currentIndex;

    private bool
        forkBool,
        feetBool,
        lionBool,
        loonieBool,
        handBool,
        hatBool,
        redBool,
        rainBootsBool,
        rabbitBool,
        kingBool,
        ringBool,
        queenBool,
        quarterBool
        ;

    //public GameObject moonTriggerBox, appleTriggerBox, astronautTriggerBox, sunTriggerBox, starTriggerBox, teacherTriggerBox, turtleTriggerBox, doorTriggerBox, dogTriggerBox, elephantTriggerBox, shoesTriggerBox, shirtTriggerBox, shipsTriggerBox;
    public GameObject[] itemTriggers;
    public GameObject[] hints;

    public GameObject
        forkGO,
        feetGO,
        lionGO,
        loonieGO,
        handGO,
        hatGO,
        redGO,
        rainBootsGO,
        rabbitGO,
        kingGO,
        ringGO,
        queenGO,
        quarterGO
        ;
    public GameObject coloredBg;

    public GameObject letterBox;
    public Sprite
        fLetter,
        lLetter,
        hLetter,
        rLetter,
        ngLetter,
        quLetter;


    private void Start()
    {
        items = GameManager._instance.items;
        index = GameManager._instance.index;

        StartCoroutine(SoundPlay(1.0f));
    }

    // single item click
    //public void ClickFork()
    //{
    //    forkGO.SetActive(true);

    //    MoveToNextItem();
    //    letterBox.GetComponent<Image>().sprite = bLetter;
    //    SoundManager._instance.bSoundPlay();
    //}

    public void ClickFork()
    {
        forkGO.SetActive(true);

        forkBool = true;
        if (forkBool && feetBool )
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = lLetter;
            SoundManager._instance.lSoundPlay();
        }
    }

    public void ClickFeet()
    {
        feetGO.SetActive(true);
        
        feetBool = true;
        if (forkBool && feetBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = lLetter;
            SoundManager._instance.lSoundPlay();
        }
    }

    public void ClickLion()
    {
        lionGO.SetActive(true);

        lionBool = true;
        if (lionBool && loonieBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = hLetter;
            SoundManager._instance.hSoundPlay();
        }
    }

    public void ClickLoonie()
    {
        loonieGO.SetActive(true);
        loonieBool = true;
        if (lionBool && loonieBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = hLetter;
            SoundManager._instance.hSoundPlay();
        }
    }

    public void ClickHand()
    {
        handGO.SetActive(true);
        handBool = true;
        if (handBool && hatBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = rLetter;
            SoundManager._instance.rSoundPlay();
        }
    }
    public void ClickHat()
    {
        hatGO.SetActive(true);
        hatBool = true;
        if (handBool && hatBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = rLetter;
            SoundManager._instance.rSoundPlay();
        }
    }



    public void ClickRed()
    {
        redGO.SetActive(true);
        redBool = true;
        if (redBool && rainBootsBool && rabbitBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = ngLetter;
            SoundManager._instance.ngSoundPlay();
        }
    }

    public void ClickRainBoots()
    {
        rainBootsGO.SetActive(true);
        rainBootsBool = true;
        if (redBool && rainBootsBool && rabbitBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = ngLetter;
            SoundManager._instance.ngSoundPlay();
        }
    }

    public void ClickRabbit()
    {
        rabbitGO.SetActive(true);
        rabbitBool = true;
        if (redBool && rainBootsBool && rabbitBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = ngLetter;
            SoundManager._instance.ngSoundPlay();
        }
    }

    public void ClickKing()
    {
        kingGO.SetActive(true);
        kingBool = true;
        if (kingBool && ringBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = quLetter;
            SoundManager._instance.quSoundPlay();
        }
    }

    public void ClickRing()
    {
        ringGO.SetActive(true);
        ringBool = true;
        if (kingBool && ringBool)
        {
            MoveToNextItem();
            letterBox.GetComponent<Image>().sprite = quLetter;
            SoundManager._instance.quSoundPlay();
        }
    }



    public void ClickQueen()
    {
        queenGO.SetActive(true);
        queenBool = true;
        if (queenBool && quarterBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }

    public void ClickQuarter()
    {
        quarterGO.SetActive(true);
        quarterBool = true;
        if (queenBool && quarterBool)
        {
            MoveToNextItem();
            SoundManager._instance.CongratulationsSoundPlay();
            StartCoroutine(coloredBgShow(1.0f));
        }
    }


    IEnumerator coloredBgShow(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        coloredBg.SetActive(true);
    }



    IEnumerator SoundPlay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SoundManager._instance.fSoundPlay();
    }

    public void MoveToNextItem()
    {
        currentIndex++;
        for (int i = 0; i < itemTriggers.Length; i++)
        {
            itemTriggers[i].SetActive(i == currentIndex);
        }
    }

    public void HintsDisplay()
    {
        for (int i = 0; i < hints.Length; i++)
        {
            hints[i].SetActive(i == currentIndex);
            StartCoroutine(HintsHide(i));
        }
    }

    IEnumerator HintsHide(int i)
    {
        yield return new WaitForSeconds(3.0f);
        hints[i].SetActive(false);
    }
}
