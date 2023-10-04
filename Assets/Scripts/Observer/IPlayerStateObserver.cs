using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ �������̽�
public interface IPlayerStateSubject
{
    // ������ ���
    void ResisterObserver(IObserver observer);

    // ������ ����
    void RemoveObserver(IObserver observer);

    // �������鿡�� ���� ����
    void NotifyObserversHPData();
    void NotifyObserversTimeData();
}

public interface IObserver
{
    // �÷��̾��� HP�� RemainTime ������Ʈ
    void UpdateHPData(int plusHP);
    void UpdateTimeData(float plusTime);
}
