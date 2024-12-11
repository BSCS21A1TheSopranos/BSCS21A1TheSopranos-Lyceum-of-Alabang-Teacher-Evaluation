using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Services
{
    // Define a class to encapsulate the feedback logic
    public static class TeacherFeedbackService
    {
        public static Dictionary<string, List<(string Feedback, string Sentiment)>> feedbacksdata = new Dictionary<string, List<(string, string)>>();
        public static void LoadStudentsTeachers(IDataSaveandRetrieve repository)
        {
            feedbacksdata = repository.GetFeedback();
        }

        public static void AddFeedback(string profId, string feedback, string sentiment)
        {
            if (!feedbacksdata.ContainsKey(profId))
            {
                feedbacksdata[profId] = new List<(string, string)>();
            }
            feedbacksdata[profId].Add((feedback, sentiment));
        }
    }
}
        

