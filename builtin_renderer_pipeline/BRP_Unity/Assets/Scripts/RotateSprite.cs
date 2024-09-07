using System;
using UnityEngine;

public class RotateSprite : MonoBehaviour
{
    public Transform centerPoint;
    public float distance = 100f;
    public float rotationTime = 5f;

    private float rotationSpeed;
    private float currentAngle = 0f;

    private void Start()
    {
        this.rotationSpeed = 360f / this.rotationTime;
    }

    private void Update()
    {

        // Update Angle
        this.currentAngle += this.rotationSpeed * Time.deltaTime;

        // To Radians
        float radians = this.currentAngle * Mathf.Deg2Rad;

        // Calc rotate moved position
        Vector3 position = this.centerPoint.position;
        float x = position.x + Mathf.Cos(radians) * this.distance;
        float y = position.y + Mathf.Sin(radians) * this.distance;

        // Update position
        this.transform.position = new Vector2(x, y);
    }
}
