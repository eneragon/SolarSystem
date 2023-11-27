using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolunebilensayilar : MonoBehaviour
{
    void Start()
    {
        List<int> bolunebilen2 = new List<int>();
        List<int> bolunebilen3 = new List<int>();
        List<int> bolunebilen4 = new List<int>();
        List<int> bolunebilen5 = new List<int>();
        List<int> tumSayilar = new List<int>();

        for (int i = 20; i <= 50; i++)
        {
            tumSayilar.Add(i);

            if (i % 2 == 0)
            {
                bolunebilen2.Add(i);
            }

            if (i % 3 == 0)
            {
                bolunebilen3.Add(i);
            }

            if (i % 4 == 0)
            {
                bolunebilen4.Add(i);
            }

            if (i % 5 == 0)
            {
                bolunebilen5.Add(i);
            }
        }

        print("Tüm sayýlar:");
        print(string.Join(", ", tumSayilar));

        print("\n2'ye bölünebilen sayýlar:");
        print(string.Join(", ", bolunebilen2));

        print("\n3'e bölünebilen sayýlar:");
        print(string.Join(", ", bolunebilen3));

        print("\n4'e bölünebilen sayýlar:");
        print(string.Join(", ", bolunebilen4));

        print("\n5'e bölünebilen sayýlar:");
        print(string.Join(", ", bolunebilen5));
    }
}
