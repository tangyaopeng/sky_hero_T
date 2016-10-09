using UnityEngine;
using System.Collections;

public class 场景漫游 : MonoBehaviour {
    //变速倍速
    public float  x = 1;
    // Use this for initialization
    //坐标变量
    private float mainx = 0;
    private float mainy = 0;
    private float mainz = 0;
    void Start () {
        mainx = this.transform.position.x;
        mainy = this.transform.position.y;
        mainz = this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        //飞行模式
        //前进
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position =new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + x);
        }
        //后退
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z -x);
        }
        //左移
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(this.transform.position.x-x, this.transform.position.y, this.transform.position.z);
        }
        //右移
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(this.transform.position.x+x, this.transform.position.y, this.transform.position.z + x);
        }
        //下降
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y-1, this.transform.position.z + x);
        }
        //上升
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+1, this.transform.position.z + x);
        }
        //加速系数改变
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            x = 10;
        }
        //加速系数回归初始值
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            x = 1;
        }
        //回到初始状态
        if (Input.GetKey(KeyCode.Space ))
        {
            this.transform.position = new Vector3(mainx,mainy ,mainz );
        }
    }
}
