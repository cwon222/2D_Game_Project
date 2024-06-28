using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerSC : MonoBehaviour
{
    public float targetTime = 2.0f;
    public float savedTargetTime;
    public int gasCount;
    public TextMeshProUGUI gasCountText;

    public GameObject gasLoad1;
    public GameObject gasLoad2;
    public GameObject gasLoad3;
    public GameObject gasLoad4;
    public GameObject gasLoad5;

    public GameObject unitLock1;
    public GameObject unitLock2;
    public GameObject unitLock3;

    public int spawnPointNumber = 1;
    public Transform spawnPointOne;
    public Transform spawnPointTwo;
    public Transform spawnPointThree;

    public GameObject unitOne;
    public GameObject unitTwo;

    private void Start()
    {
        gasCountText.text = gasCount.ToString();
        savedTargetTime = targetTime;
    }

    private void Update()
    {
        targetTime -= Time.deltaTime;

        if(targetTime <= 0)
        {
            TimerEnded();
        }

        if(targetTime > (savedTargetTime * .8))
        {
            gasLoad1.SetActive(false);
            gasLoad2.SetActive(false);
            gasLoad3.SetActive(false);
            gasLoad4.SetActive(false);
            gasLoad5.SetActive(false);
        }
        if(targetTime <= (savedTargetTime * .84))
        {
            gasLoad1.SetActive(true);
        }
        if (targetTime <= (savedTargetTime * .68))
        {
            gasLoad2.SetActive(true);
        }
        if (targetTime <= (savedTargetTime * .52))
        {
            gasLoad3.SetActive(true);
        }
        if (targetTime <= (savedTargetTime * .36))
        {
            gasLoad4.SetActive(true);
        }
        if (targetTime <= (savedTargetTime * .2))
        {
            gasLoad5.SetActive(true);
        }

        ///

        if(gasCount >= 3)
        {
            unitLock1.SetActive(false);
        }
        else
        {
            unitLock1.SetActive(true);
        }

        if(gasCount >= 5)
        {
            unitLock2.SetActive(false);
        }
        else
        {
            unitLock2.SetActive(true);
        }

        if (gasCount >= 8)
        {
            unitLock3.SetActive(false);
        }
        else
        {
            unitLock3.SetActive(true);
        }
    }

    void TimerEnded()
    {
        gasCount++;
        gasCountText.text = gasCount.ToString();
        targetTime = 2.0f;
    }

    public void BuyUnitOne()
    {
        gasCount -= 3;
        gasCountText.text = gasCount.ToString();
        if(spawnPointNumber == 1)
        {
            Instantiate(unitOne, spawnPointOne.position, spawnPointOne.rotation, transform);
            spawnPointNumber = 2;
        }
        else if(spawnPointNumber == 2)
        {
            Instantiate(unitOne, spawnPointTwo.position, spawnPointTwo.rotation, transform);
            spawnPointNumber = 3;
        }
        else if (spawnPointNumber == 3)
        {
            Instantiate(unitOne, spawnPointThree.position, spawnPointThree.rotation, transform);
            spawnPointNumber = 1;
        }
    }

    public void BuyUnitTwo()
    {
        gasCount -= 5;
        gasCountText.text = gasCount.ToString();
        if (spawnPointNumber == 1)
        {
            Instantiate(unitTwo, spawnPointOne.position, spawnPointOne.rotation, transform);
            spawnPointNumber = 2;
        }
        else if (spawnPointNumber == 2)
        {
            Instantiate(unitTwo, spawnPointTwo.position, spawnPointTwo.rotation, transform);
            spawnPointNumber = 3;
        }
        else if (spawnPointNumber == 3)
        {
            Instantiate(unitTwo, spawnPointThree.position, spawnPointThree.rotation, transform);
            spawnPointNumber = 1;
        }
    }

    public void BuyUnitThree()
    {
        gasCount -= 8;
        gasCountText.text = gasCount.ToString();
        //bluePlane.attackPlane();
        SpawnPlane();   // 임시 코드
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }

    // 임시 코드 ---------------------------------------------
    public GameObject unitThree;
    void SpawnPlane()
    {
        if (spawnPointNumber == 1)
        {
            Instantiate(unitThree, spawnPointOne.position, spawnPointOne.rotation, transform);
            spawnPointNumber = 2;
        }
        else if (spawnPointNumber == 2)
        {
            Instantiate(unitThree, spawnPointTwo.position, spawnPointTwo.rotation, transform);
            spawnPointNumber = 3;
        }
        else if (spawnPointNumber == 3)
        {
            Instantiate(unitThree, spawnPointThree.position, spawnPointThree.rotation, transform);
            spawnPointNumber = 1;
        }
    }
}
