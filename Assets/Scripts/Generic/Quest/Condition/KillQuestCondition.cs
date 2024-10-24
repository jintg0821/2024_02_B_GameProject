using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    //���� óġ ����Ʈ��  ������ �����ϴ� Ŭ����
    public class KillQuestCondition : IQuestCondition
    {
        
        private string enemyType;   //óġ�ؾ� �� ���� ����
        private int requiredKills;  //óġ�ؾ� �� �� ���� ��        
        private int currKills;      //������� óġ�� ���� ��
 
        public KillQuestCondition(string enemyType, int requiredKills)  //óġ ����Ʈ ���� �ʱ�ȭ ������
        {
            this.enemyType = enemyType;
            this.requiredKills = requiredKills;
            this.currKills = 0;
        } 
        public bool IsMet() => currKills >= requiredKills;      //��ǥ óġ ���� �޼� �ߴ��� Ȯ��
        public void Initialize() => currKills = 0;              //óġ ���� 0���� �ʱ�ȭ
        public float GetProgress() => (float)currKills / requiredKills; //���� óġ ���൵�� �ۼ�Ʈ�� ��ȯ
        public string GetDescription() => $"Defeat {requiredKills} {enemyType} ({currKills}/{requiredKills})";  //����Ʈ ���� ������ ���ڿ��� ��ȯ

        public void EnemyKilled(string enemyType)   //�� óġ �� ȣ��Ǵ� �޼���
        {
            if (this.enemyType == enemyType)
            {
                currKills++;
            }
        }
    }
}

