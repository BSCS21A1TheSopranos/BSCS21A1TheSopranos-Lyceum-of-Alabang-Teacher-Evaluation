
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public static class StudentTeacherData
    {

        public static Dictionary<string, List<(string ProfID, string Subject, string Status)>> studentTeacherData = new Dictionary<string, List<(string, string, string)>>();
        public static void LoadStudentsTeachers(IDataSaveandRetrieve repository)
        {
            studentTeacherData = repository.GetStudentsTeachers();
        }

        public static void UpdateStatusInDictionary(string studentId, string teacherId)
        {
            if (StudentTeacherData.studentTeacherData.ContainsKey(studentId))
            {
                var teacherRecords = StudentTeacherData.studentTeacherData[studentId];
                for (int i = 0; i < teacherRecords.Count; i++)
                {
                    if (teacherRecords[i].ProfID == teacherId)
                    {
                        teacherRecords[i] = (teacherRecords[i].ProfID, teacherRecords[i].Subject, "Done");
                        break;
                    }
                }
                MSAcessDataSaveandRetrieve mSAcessDataSaveandRetrieve = new MSAcessDataSaveandRetrieve();
                mSAcessDataSaveandRetrieve.SaveStudentsTeachers();
            }
        }
        public static void RemoveTeacherFromStudentTeacherData(string profID)
        {
            foreach (var studentId in studentTeacherData.Keys.ToList())
            {
                var teacherRecords = studentTeacherData[studentId];
                teacherRecords.RemoveAll(record => record.ProfID == profID);

                if (teacherRecords.Count == 0)
                {
                    studentTeacherData.Remove(studentId);
                }
                else
                {
                    studentTeacherData[studentId] = teacherRecords;
                }
            }

            MSAcessDataSaveandRetrieve mSAcessDataSaveandRetrieve = new MSAcessDataSaveandRetrieve();
            mSAcessDataSaveandRetrieve.SaveStudentsTeachers();
        }
        public static void AddStudentTeacherRecord(string studentId, string professorId, string subject)
        {
            if (!studentTeacherData.ContainsKey(studentId))
            {
                studentTeacherData[studentId] = new List<(string ProfID, string Subject, string Status)>();
            }
            studentTeacherData[studentId].Add((professorId, subject, "Pending"));
            MSAcessDataSaveandRetrieve mSAcessDataSaveandRetrieve = new MSAcessDataSaveandRetrieve();
            mSAcessDataSaveandRetrieve.SaveStudentsTeachers();
        }

        public static string CountStudentsByProfessor(string professorId)
        {
            int count = 0;
            foreach (var studentRecord in studentTeacherData.Values)
            {
                if (studentRecord.Any(record => record.ProfID == professorId))
                {
                    count++;
                }
            }
            return count.ToString();
        }

        public static string CountStatusDoneForProfessor(string professorId)
        {
            int count = 0;

            foreach (var studentRecord in studentTeacherData.Values)
            {
                count += studentRecord.Count(record => record.ProfID == professorId && record.Status == "Done");
            }
            return count.ToString();
        }


        public static string CountUniqueSubjectsForProfessor(string professorId)
        {
            HashSet<string> subjects = new HashSet<string>();
            foreach (var studentRecord in studentTeacherData.Values)
            {
                foreach (var record in studentRecord)
                {
                    if (record.ProfID == professorId)
                    {
                        subjects.Add(record.Subject);
                    }
                }
            }
            return subjects.Count.ToString();
        }

        public static string CountStudentsDoneWithAllProfessors()
        {
            int count = 0;

            foreach (var studentRecord in studentTeacherData)
            {
                if (studentRecord.Value.All(record => record.Status == "Done"))
                {
                    count++;
                }
            }

            return count.ToString();
        }




    }
}
