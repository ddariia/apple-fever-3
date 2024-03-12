using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSplitter : MonoBehaviour
{
    public GameObject appleHalfPrefab; // ѕрефаб половинки €блука

    public void SplitApple()
    {
        // —творюЇмо дв≥ половинки €блука на м≥сц≥ поточного €блука
        GameObject appleHalf1 = Instantiate(appleHalfPrefab, transform.position, Quaternion.identity);
        GameObject appleHalf2 = Instantiate(appleHalfPrefab, transform.position, Quaternion.identity);

        // ƒодаЇмо ф≥зику до половинок €блука
        Rigidbody2D rb1 = appleHalf1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = appleHalf2.GetComponent<Rigidbody2D>();

        // ЌалаштовуЇмо швидк≥сть та напр€мок руху половинок €блука
        rb1.AddForce(Vector2.left * Random.Range(1f, 2f), ForceMode2D.Impulse);
        rb2.AddForce(Vector2.right * Random.Range(1f, 2f), ForceMode2D.Impulse);

        // «нищуЇмо ориг≥нальне €блуко
        Destroy(gameObject);
    }
}
