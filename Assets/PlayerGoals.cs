using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerGoals : MonoBehaviour
{
    public TextMeshProUGUI todoList;
    public TextMeshProUGUI doneList;

    public void AddGoal(string name)
    {
        todoList.text += ToListString(name);
    }

    public void CompleteGoal(string name)
    {
        var str = ToListString(name);

        var idx = todoList.text.IndexOf(str);

        if (idx == -1)
        {
            return;
        }

        todoList.text = todoList.text.Remove(idx, str.Length);

        doneList.text += str;
    }


    private string ToListString(string name)
    {
        return $"\n-{name}";
    }
}
