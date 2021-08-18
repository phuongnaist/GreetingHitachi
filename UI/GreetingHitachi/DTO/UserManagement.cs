using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingHitachi.DTO
{
    static class UserManagement
    {
        public struct AttendingPersons {
            public List<int> personID;
            public List<string> attendingDate;
        };
        private static string globalUserName = "";
        public static int numQuestion = 10;
        public static int numStaff = 10;
        public static string questionContent = "";
        public static string correctAnswer = "";
        public static string wrongAnswer1 = "";
        public static string wrongAnswer2 = "";
        public static string dpChoice1 = "";
        public static string dpChoice2 = "";
        public static string dpChoice3 = "";
        public static string valueChoice = "";
        public static string ansExplain = "";
        public static AttendingPersons attendingPersons;
        
        public static bool showImage = false;
        public static Random random = new Random();
        public static Image image = Image.FromFile(@"G:\\.shortcut-targets-by-id\\1bBGGyUtJMVISKw2Sr2Dcs7nq3n_hNQvY\\PBL\\Software\\UI\\GreetingHitachi\\Employee_Image\\1.SonHongPham.png");
        // Type: 0 ABC, 1 ACB, 2 BAC, 3 BCA, 4 CAB, 5 CBA 
        public static int[] answerOrder = { 3, 4, 5 };
        public static int sequenceType = 1;
        public static int vote1 = 0;
        public static int vote2 = 0;
        public static int vote3 = 0;
        public static int vote4 = 0;
        public static int vote5 = 0;

        public static (int, int, int) SortAttending (AttendingPersons attendingPersons)
        {
            string maxDate = attendingPersons.attendingDate[0];
            int maxIndex = 0;
            int maxSelect = 3;
            int firstrmIndex = 0;
            int secondrmIndex = 1;
            int thirdrmIndex = 2;
            for (int j=0;j<maxSelect;j++)
            {
                for (int i = 0; i < attendingPersons.personID.Count; i++)
                {
                    if (j == 0)
                    {
                        if (String.Compare(maxDate, attendingPersons.attendingDate[i]) < 0)
                        {
                            maxDate = attendingPersons.attendingDate[i];
                            maxIndex = attendingPersons.personID[i];
                        }
                    }
                    else if (j==1){
                        if ((String.Compare(maxDate, attendingPersons.attendingDate[i]) < 0) && (i!=firstrmIndex-1))
                        {
                            maxDate = attendingPersons.attendingDate[i];
                            maxIndex = attendingPersons.personID[i];
                        }
                    }
                    else
                    {
                        if (String.Compare(maxDate, attendingPersons.attendingDate[i]) < 0 && i != firstrmIndex-1 && i != secondrmIndex-1)
                        {
                            maxDate = attendingPersons.attendingDate[i];
                            maxIndex = attendingPersons.personID[i];
                        }
                    }

                    if (i == attendingPersons.personID.Count - 1)
                    {
                        maxDate = "";
                        if (j == 0)
                        {
                            firstrmIndex = maxIndex;
                            
                        }
                        else if (j == 1)
                        {
                            secondrmIndex = maxIndex;
                        }
                        else
                        {
                            thirdrmIndex = maxIndex;
                        }
                    }
                }
            }
            return (firstrmIndex, secondrmIndex, thirdrmIndex);
        }
        public static void MixAnswer(int[] answerOrder)
        {
            sequenceType = random.Next(5);
            if(sequenceType == 0)
            {
                answerOrder[0] = 3;
                answerOrder[1] = 4;
                answerOrder[2] = 5;
            }
            else if (sequenceType == 1){
                //answerOrder = new int[] { 3, 5, 4 };
                answerOrder[0] = 3;
                answerOrder[1] = 5;
                answerOrder[2] = 4;
            }
            else if (sequenceType == 2)
            {
                //answerOrder = new int[] { 4, 3, 5 };
                answerOrder[0] = 4;
                answerOrder[1] = 3;
                answerOrder[2] = 5;
            }
            else if (sequenceType == 3)
            {
                //answerOrder = new int[] { 4, 5, 3 };
                answerOrder[0] = 4;
                answerOrder[1] = 5;
                answerOrder[2] = 3;
            }
            else if (sequenceType == 4)
            {
                //answerOrder = new int[] { 5, 3, 4 };
                answerOrder[0] = 5;
                answerOrder[1] = 3;
                answerOrder[2] = 4;
            }
            else
            {
                //answerOrder = new int[] { 5, 4, 3 };
                answerOrder[0] = 5;
                answerOrder[1] = 4;
                answerOrder[2] = 3;
            }
        }
        public static string GlobalVar
        {
            get { return globalUserName; }
            set { globalUserName = value; }
        }
    }
}
