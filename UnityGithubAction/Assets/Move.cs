using UnityEngine;

public class AutoFloat : MonoBehaviour
{
    public float height = 2.0f;   // 浮动的高度范围
    public float speed = 2.0f;    // 浮动的速度

    void Update()
    {
        // 获取物体初始的 Y 轴位置（假设初始位置是 0，或者你可以定义一个变量存初始位置）
        float startY = transform.position.y; 

        // Mathf.PingPong 会让数值在 0 和 height 之间来回变化
        // Time.time * speed 让数值随时间变化
        float offset = Mathf.PingPong(Time.time * speed, height);

        // 更新位置，保持 X 和 Z 不变，只改变 Y
        // 注意：这里简化处理，实际使用中建议记录初始位置 Vector3 startPos
        transform.position = new Vector3(transform.position.x, startY + offset, transform.position.z);
    }
}