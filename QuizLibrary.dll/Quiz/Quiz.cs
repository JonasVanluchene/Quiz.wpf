using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary.dll.Quiz
{
    internal class Quiz
    {
        string QuizName;
        List<Question> QuestionList;

        public Quiz(string quizName)
        {
            QuizName = quizName;            
        }
        public Quiz(string quizName, List<Question> questionList)
        {
            QuizName = quizName;
            QuestionList = questionList;
        }
    }
}
