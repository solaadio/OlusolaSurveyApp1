using System;
using System.Collections.Generic;
using OlusolaSurveyApp1.DataObjects;

namespace OlusolaSurveyApp1
{
    static class DataFactory
    {
        public static List<SurveyQuestions> Questions
        {
            get
            {
                return new List<SurveyQuestions>
                {
                    new SurveyQuestions { Id = Guid.NewGuid().ToString(),
                        Text = "Where should we have lunch?",
                        Answers = "McDonalds|Sushi King|Olive Garden|Outback Steakhouse|KFC" },
                    new SurveyQuestions { Id = Guid.NewGuid().ToString(),
                        Text = "PARTY! Which date do you prefer?",
                        Answers = "Monday|Wednesday|Friday" },
                    new SurveyQuestions { Id = Guid.NewGuid().ToString(),
                        Text = "Which mobile platform do you like best?",
                        Answers = "Android|iOS|UWP|WPF|HTML|Blackberry" }
                };
            }
        }
    }
}