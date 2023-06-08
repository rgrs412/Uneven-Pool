using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEventAssigner : MonoBehaviour
{
    GameObject buttonAudio;
    AudioSource [] audioSource;
    void Start()
    {
        //The ButtonAudio object is only created on the 'Menu' scene with DontDestroyOnLoad applied.
        //So this try-catch block doesnt handle the exception if starting from a scene other than 'Menu'
        try
        {
            buttonAudio = GameObject.FindGameObjectWithTag("ButtonAudio");
            audioSource = buttonAudio.GetComponents<AudioSource>();
        }
        catch (System.Exception)
        {
        }

        EventTrigger trigger = gameObject.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;
        entry.callback.AddListener((data) => { OnPointerEnterDelegate((PointerEventData)data); });
        trigger.triggers.Add(entry);


        EventTrigger.Entry entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerDown;
        entry2.callback.AddListener((data) => { OnPointerDownDelegate((PointerEventData)data); });
        trigger.triggers.Add(entry2);
    }

    public void OnPointerEnterDelegate(PointerEventData data)
    {
        audioSource[0].Play();
    }

    public void OnPointerDownDelegate(PointerEventData data)
    {
       audioSource[1].Play();
    }
}
