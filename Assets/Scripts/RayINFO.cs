using UnityEngine;
public class RayINFO : MonoBehaviour
{
    public Camera cam;
    public void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition); // ����������� ����� � ���, mousePosition - ����� �� ������.
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction); //���� ����������� � �����������, origin - ������ ����, direction - ����������� ����.
        if (hit.collider != null)
        {

        }
        RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction); // �����, ������� ������� ��� ���������� ������� ���������� ��� � ����.
        gameObject.CompareTag("Player"); // ��������� ��� ������ ����� ��� Player
        gameObject.tag = "Player"; // ���������� ���� �������. 
        GameObject.FindGameObjectWithTag("Player"); // ����� �������� ������� � ����� ...

        //���� ����� �������� ������ � �����, ����� ������������ 
        ZombieAI zombie = GetComponent<ZombieAI>(); //������� Zombie zombie = new Zombie(); �������� new �������� ������ ��� ��������� ���� � �����
        //��� �� ������� ������ � ������ Unity



    }
}