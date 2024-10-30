using UnityEngine;
using System.Collections;

public class ShootableBox : MonoBehaviour {

    //Текущее здоровье данного обьекта (сколько раз должны выстрелить чтобы поразить обьект)
    public int currentHealth = 1;
    //Метод поражения цели (он принимает параметр целого числа.Данное значение вычитается из параметра здоровья (currentHealth ) )
    public void Damage(int damageAmount)
    {
        //Вычитание
        currentHealth -= damageAmount;

        //Условие  проверки уровня здоровья
        if (currentHealth <= 0) 
        {
            //Если он меньше нуля,то цель скрывается
            gameObject.SetActive (false);
        }
    }
}