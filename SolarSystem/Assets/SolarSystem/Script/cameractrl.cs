using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameractrl : MonoBehaviour {
    //方向灵敏度  
    public float sensitivityX = 10F;
    public float sensitivityY = 10F;

    //上下最大视角(Y视角)  
    public float minimumY = -60F;
    public float maximumY = 60F;

    float rotationY = 0F;

    // Use this for initialization  
    private GameObject gameObject;

    public static int i;
    private GameObject camera1;
    private GameObject camera2;
    private GameObject camera3;
    private GameObject camera4;
    private GameObject camera5;
    private GameObject camera6;
    private GameObject camera7;
    private GameObject camera8;

    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;


    void Start()
    {
        i = 1;
        camera1 = GameObject.Find("Camera (1)");
        camera2 = GameObject.Find("Camera (2)");
        camera3 = GameObject.Find("Camera (3)");
        camera4 = GameObject.Find("Camera (4)");
        camera5 = GameObject.Find("Camera (5)");
        camera6 = GameObject.Find("Camera (6)");
        camera7 = GameObject.Find("Camera (7)");
        camera8 = GameObject.Find("Camera (8)");
        
        gameObject = camera1;
    }

    void Close()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
        camera5.SetActive(false);
        camera6.SetActive(false);
        camera7.SetActive(false);
        camera8.SetActive(false);
    }
    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Close();
            camera1.SetActive(true);
            gameObject = camera1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            Close();
            camera2.SetActive(true);
            gameObject = camera2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            Close();
            camera3.SetActive(true);
            gameObject = camera3;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            Close();
            camera4.SetActive(true);
            gameObject = camera4;
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            Close();
            camera5.SetActive(true);
            gameObject = camera5;
        }
        else if (Input.GetKey(KeyCode.Alpha6))
        {
            Close();
            camera6.SetActive(true);
            gameObject = camera6;
        }
        else if (Input.GetKey(KeyCode.Alpha7))
        {
            Close();
            camera7.SetActive(true);
            gameObject = camera7;
        }
        else if (Input.GetKey(KeyCode.Alpha8))
        {
            Close();
            camera8.SetActive(true);
            gameObject = camera8;
        }
        else
        {
            i = 1;
        }


        //空格键抬升高度  
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        }

        //w键前进  
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(new Vector3(0, 0, 50 * Time.deltaTime));
        }
        //s键后退  
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(new Vector3(0, 0, -50 * Time.deltaTime));
        }
        //a键后退  
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(new Vector3(-10, 0, 0 * Time.deltaTime));
        }
        //d键后退  
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(new Vector3(10, 0, 0 * Time.deltaTime));
        }
        



        //根据鼠标移动的快慢(增量), 获得相机左右旋转的角度(处理X)  
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

        //根据鼠标移动的快慢(增量), 获得相机上下旋转的角度(处理Y)  
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        //角度限制. rotationY小于min,返回min. 大于max,返回max. 否则返回value   
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        //总体设置一下相机角度  
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
