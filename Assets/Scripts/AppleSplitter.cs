using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSplitter : MonoBehaviour
{
    public GameObject appleHalfPrefab; // ������ ��������� ������

    public void SplitApple()
    {
        // ��������� �� ��������� ������ �� ���� ��������� ������
        GameObject appleHalf1 = Instantiate(appleHalfPrefab, transform.position, Quaternion.identity);
        GameObject appleHalf2 = Instantiate(appleHalfPrefab, transform.position, Quaternion.identity);

        // ������ ������ �� ��������� ������
        Rigidbody2D rb1 = appleHalf1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = appleHalf2.GetComponent<Rigidbody2D>();

        // ����������� �������� �� �������� ���� ��������� ������
        rb1.AddForce(Vector2.left * Random.Range(1f, 2f), ForceMode2D.Impulse);
        rb2.AddForce(Vector2.right * Random.Range(1f, 2f), ForceMode2D.Impulse);

        // ������� ���������� ������
        Destroy(gameObject);
    }
}
