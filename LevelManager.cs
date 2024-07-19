using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levels;
    public SceneLoadManagers levelcode;
    // Start is called before the first frame update
    void Start()
    {
        levelcode = Object.FindObjectOfType<SceneLoadManagers>();
    }

    // Update is called once per frame
    void Update()
    {
        levelsecici();
    }
    public void levelsecici()
    {
        for(int i=0; i<levels.Length; i++) {
            levels[i].SetActive(false);
            switch (PlayerPrefs.GetInt("openlevels"))
            {
                case 0:
                    levels[0].SetActive(true);
                    break;

                case 1:
                    levels[0].SetActive(true);
                    break;

                case 2:
                    levels[1].SetActive(true);
                    break;

                case 3:
                    levels[2].SetActive(true);
                    break;

                case 4:
                    levels[3].SetActive(true);
                    break;

                case 5:
                    levels[4].SetActive(true);
                    break;

                case 6:
                    levels[5].SetActive(true);
                    break;

                case 7:
                    levels[6].SetActive(true);
                    break;

                case 8:
                    levels[7].SetActive(true);
                    break;

                case 9:
                    levels[8].SetActive(true);
                    break;

                case 10:
                    levels[9].SetActive(true);
                    break;

                case 11:
                    levels[10].SetActive(true);
                    break;

                case 12:
                    levels[11].SetActive(true);
                    break;

                case 13:
                    levels[12].SetActive(true);
                    break;

                case 14:
                    levels[13].SetActive(true);
                    break;

                case 15:
                    levels[14].SetActive(true);
                    break;

                case 16:
                    levels[15].SetActive(true);
                    break;

                case 17:
                    levels[16].SetActive(true);
                    break;

                case 18:
                    levels[17].SetActive(true);
                    break;

                case 19:
                    levels[18].SetActive(true);
                    break;

                case 20:
                    levels[19].SetActive(true);
                    break;

            }
        }
    }
}
