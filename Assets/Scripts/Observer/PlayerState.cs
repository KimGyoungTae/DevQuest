using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour, IPlayerStateSubject
{
    private List<IObserver> observers = new List<IObserver>();

    [SerializeField] private int plusHp;
    public int HP
    {
        get { return plusHp; }

        set 
        { 
            // HP���� �޾� �����ϰڴٴ� ���� ���������� �˸�..
            plusHp = value;
            NotifyObserversHPData();
        }
    }

    [SerializeField] private float plusTime;
    public float RemainTime
    {
        get { return plusTime; }

        set 
        { 
            plusTime = value;
            //   Debug.Log("�� ����.. ");
            NotifyObserversTimeData();
        }
    }

    public bool IsAttack { get; set; }


public void ResisterObserver(IObserver observer)
    {
        observers.Add(observer);
        Debug.Log("������ ���");
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObserversHPData()
    {
        foreach (IObserver observer in observers)
        {
            observer.UpdateHPData(plusHp);
        }
    }
    public void NotifyObserversTimeData()
    {
        foreach(IObserver observer in observers)
        {
            observer.UpdateTimeData(plusTime);
        }
    }
}



