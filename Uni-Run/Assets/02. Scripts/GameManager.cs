using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// ���ӿ��� ���¸� ǥ���ϰ�, ���� ������ UI��
// �����ϴ� ���� �Ŵ���, ������ �� �ϳ��� ���� �Ŵ����� 
// ������ �� ����
public class GameManager : MonoBehaviour
{
    // �̱����� �Ҵ��� ���� ����
    public static GameManager instance;

    public bool isGameover = false; // ���ӿ��� ����
    public Text scoreText; // ������ ����� UI �ؽ�Ʈ
    // ���ӿ��� �� Ȱ��ȭ�� UI ���� ������Ʈ
    public GameObject gameoverUI;

    private int score = 0; // ���� ����

    // ���� ���۰� ���ÿ� �̱����� ����
    private void Awake()
    {
        // �̱��� ���� instance�� ��� �ִ°�?
        if(instance == null)
        {
            // instance�� ��� �ִٸ�(null) �װ��� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            // instance�� �̹� �ٸ� GameManager ������Ʈ��
            // �Ҵ�Ǿ� �ִ� ���

            // ���� �� �� �̻��� GameManager ������Ʈ�� �����Ѵٴ�
            // �ǹ�, �̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ�
            // �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // ���ӿ��� ���¿��� ������ ������� �� �ְ� �ϴ� ó��
        if(isGameover && Input.GetMouseButtonDown(0))
        {
            // ���ӿ��� ���¿��� ���콺 ���� ��ư�� Ŭ���ϸ�
            // ���� �� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // ������ ������Ű�� �޼���
    public void AddScore(int newScore)
    {
        // ���ӿ����� �ƴ϶��
        if (!isGameover)
        {
            // ������ ����
            score += newScore;
            scoreText.text = "Score : " + score;
        }
    }

    // �÷��̾� ĳ���� ��� �� ���ӿ����� �����ϴ� �޼���
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
