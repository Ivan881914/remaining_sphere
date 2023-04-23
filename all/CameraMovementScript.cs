using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    [SerializeField] private Transform target; // объект, за которым будет следовать камера
    [SerializeField] private Vector3 offset; // расстояние между камерой и объектом
    [SerializeField] private float smoothSpeed = 0.125f; // скорость плавного перемещения камеры

    private Vector3 velocity = Vector3.zero; // скорость перемещения камеры
    
    private void LateUpdate() // Выполняется после выполнения всех функций обновления
    {
        // Создать кватернион, задающий поворот камеры вокруг осей x и z на 45 градусов
        Quaternion rotation = Quaternion.Euler(-45f, 0f, 0f);
        
        // Применить поворот к смещению камеры
        Vector3 rotatedOffset = rotation * offset;
        
        // Вычислить позицию, к которой камера должна двигаться
        Vector3 desiredPosition = target.position + rotatedOffset;
        
        // Интерполировать между текущей позицией камеры и желаемой позицией с использованием скорости
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
        
        // Установить позицию камеры на плавно перемещенную позицию
        transform.position = smoothedPosition;
        
        // Смотреть на объект
        transform.LookAt(target.position);
    }
}