using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF
{
    class AnswerGenerator
    {
        string[] answers = new string[] { "你好","我好","大家好","才是真的好","广州好的","河南","郑州","龙子湖","河中医"};
        public string GetRandomAnswer(string question)
        {
            Random ran = new Random();
            return answers[ran.Next(0,answers.Length)];
        }
    }
}
