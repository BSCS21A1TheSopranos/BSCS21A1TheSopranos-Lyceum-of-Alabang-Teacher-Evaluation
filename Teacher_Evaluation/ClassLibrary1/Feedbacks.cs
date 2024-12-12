using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Services
{
    // Define a class to encapsulate the feedback logic
    public static class TeacherFeedbackService
    {
        public static Dictionary<string, List<(string Feedback, string Sentiment, string Date)>> feedbacksdata = new Dictionary<string, List<(string, string, string)>>();
        public static void LoadStudentsTeachers(IDataSaveandRetrieve repository)
        {
            feedbacksdata = repository.GetFeedback();
        }

        public static void AddFeedback(string profId, string feedback, string sentiment,string date)
        {
            if (!feedbacksdata.ContainsKey(profId))
            {
                feedbacksdata[profId] = new List<(string, string, string)>();
            }
            feedbacksdata[profId].Add((feedback, sentiment, date));
            MSAcessDataSaveandRetrieve ms = new MSAcessDataSaveandRetrieve();
            ms.SaveFeedback();
        }

        public static string CalculateCreditPoints(string profId)
        {
            
            var totalStudents = int.Parse(StudentTeacherData.CountStatusDoneForProfessor(profId));
            if (!feedbacksdata.ContainsKey(profId))
            {
                return "100%";
            }
            int positiveFeedbackCount = 0;
            int negativeFeedbackCount = 0;
            foreach (var feedbackEntry in feedbacksdata[profId])
            {
                if (feedbackEntry.Sentiment.ToLower() == "positive")
                {
                    positiveFeedbackCount++;
                }
                else if (feedbackEntry.Sentiment.ToLower() == "negative")
                {
                    negativeFeedbackCount++;
                }
            }
            double positiveImpact = positiveFeedbackCount * (100.0 / totalStudents);
            double negativeImpact = negativeFeedbackCount * (100.0 / totalStudents);
            double creditPoints = 100.0 + (positiveImpact - negativeImpact);
            return creditPoints.ToString() + "%";
        }

    }
}
        

