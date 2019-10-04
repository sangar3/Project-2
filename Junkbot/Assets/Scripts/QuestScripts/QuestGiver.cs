using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public GameObject player;

    public GameObject questWindow;

    public Text titletext;
    public Text descriptiontext;

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        titletext.text = quest.title;
        descriptiontext.text = quest.description;
    }


}
