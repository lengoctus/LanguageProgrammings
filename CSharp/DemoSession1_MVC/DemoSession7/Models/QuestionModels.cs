using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession7.Models
{
    public class QuestionModels
    {
        private List<Question> Questions;
        public QuestionModels()
        {
            Questions = new List<Question>
            {
                new Question {
                    Id = 01,
                    Content= "Question 1",
                    Answers = new List<Answer>{
                        new Answer{
                        Id = 1,
                        Content = "Answer 1.1",
                        Correct = true,
                        },
                        new Answer{
                        Id = 2,
                        Content = "Answer 1.2",
                        Correct = true,
                        }
                    }
                },

                new Question {
                    Id = 02,
                    Content= "Question 2",
                    Answers = new List<Answer>{
                        new Answer{
                        Id = 1,
                        Content = "Answer 2.1",
                        Correct = false,
                        },
                        new Answer{
                        Id = 2,
                        Content = "Answer 2.2",
                        Correct = true,
                        }
                    }
                },

                 new Question {
                    Id = 03,
                    Content= "Question 3",
                    Answers = new List<Answer>{
                        new Answer{
                        Id = 1,
                        Content = "Answer 3.1",
                        Correct = false,
                        },

                        new Answer{
                        Id = 2,
                        Content = "Answer 3.2",
                        Correct = true,
                        }
                    },

                },

                 new Question {
                    Id = 04,
                    Content= "Question 4",
                    Answers = new List<Answer>{
                        new Answer{
                        Id = 1,
                        Content = "Answer 4.1",
                        Correct = true,
                        },
                        new Answer{
                        Id = 2,
                        Content = "Answer 4.2",
                        Correct = true,
                        }
                    }
                },
                 new Question {
                    Id = 05,
                    Content= "Question 5",
                    Answers = new List<Answer>{
                        new Answer{
                        Id = 1,
                        Content = "Answer 5.1",
                        Correct = false,
                        },
                         new Answer{
                        Id = 2,
                        Content = "Answer 5.2",
                        Correct = false,
                        }
                    }
                 }
            };
        }

        public List<Question> FindAll()
        {

            return Questions;
        }

        public Question Find(int id)
        {
            return Questions.SingleOrDefault(p => p.Id == id);
        }
    }
}
