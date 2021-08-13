using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transfermap : MonoBehaviour
{
    public string transferMapName; //�̵��� ���� �̸�
    private MovingObject thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<MovingObject>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            thePlayer.currentMapName = transferMapName;//�÷��̾��� ���� ���� �̵��ϰ����ϴ� ���� ��
            SceneManager.LoadScene(transferMapName);//�̵��ϰ��� �ϴ� ���� �ε���.
        }

    }
}
