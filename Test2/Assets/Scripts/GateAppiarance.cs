using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum DeformationType //enum для выпадающей менюшки в юнити
{
    Whidth,
    Height
}

public class GateAppiarance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

   

    //Иконки увеличения/уменьшения ширины
     [SerializeField] GameObject _expandLable;
     [SerializeField] GameObject _shrinkLable;

    //Иконки уеличения/уменьшения высоты
    [SerializeField] GameObject _upLable;
    [SerializeField] GameObject _downLable;
    public void UpdateVisual (DeformationType deformationType, int value) //значения меняются в инспекторе. Воротам не нужно меняться каждый кадр, поэтому используем не Апдейт
    {
        string prefix = "";
        

        if (value > 0) { //если число положительное (цвет ворот сереневый)
            prefix = "+";
            SetColor(_colorPositive);
        } else if (value == 0) {
            SetColor(Color.grey);
        }

        else
        {
           SetColor(_colorNegative);
        }
        _text.text =prefix + value.ToString(); //перевод числа в строку


        _expandLable.SetActive(false);
        _shrinkLable.SetActive(false);
        _upLable.SetActive(false);
        _downLable.SetActive(false);

        if (deformationType == DeformationType.Whidth)
        {
                if (value>0 )
                {
                    _expandLable.SetActive(true);
                } else{
                    _shrinkLable.SetActive(true);
                }
        } 
        else if (deformationType == DeformationType.Height){
                if (value>0 )
                {
                    _upLable.SetActive(true);
                } else{
                    _downLable.SetActive(true);
                }
        }
    }

    void SetColor(Color color) //то что передается в этот метод назначается верхней картинкой и нижней картинкой (Color - тип, color - переменная)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }
}
