using UnityEngine;
public class RayINFO : MonoBehaviour
{
    public Camera cam;
    public void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition); // Преобразуем точку в луч, mousePosition - точка на камере.
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction); //Ищем пересечение с коллайдером, origin - начало луча, direction - направление луча.
        if (hit.collider != null)
        {

        }
        RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction); // лазер, который находит все коллайдеры которые пересекают его в луче.
        gameObject.CompareTag("Player"); // Сравнение что объект имеет тэг Player
        gameObject.tag = "Player"; // присвоение тэга объекту. 
        GameObject.FindGameObjectWithTag("Player"); // поиск игрового объекта с тэгом ...

        //если нужно передать данные в класс, нужно использовать 
        ZombieAI zombie = GetComponent<ZombieAI>(); //никаких Zombie zombie = new Zombie(); операция new выделяет память для значимого типа в стэке
        //она не передаёт данные в движок Unity



    }
}