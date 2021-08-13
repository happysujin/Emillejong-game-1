using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    static public MovingObject instance;
    public string currentMapName; //transferMap ��ũ��Ʈ�� �ִ� transferMapName ������ ���� ����
    public float speed;

    private Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

            if(vector.x != 0)
            {
                transform.Translate(vector.x * speed, 0, 0);
            }
            else if(vector.y != 0)
            {
                transform.Translate(0, vector.y * speed, 0);
            }
        }
            
    }
}
