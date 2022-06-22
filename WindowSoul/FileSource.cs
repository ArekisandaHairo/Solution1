using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace WindowSoul
{
    /*
             * Сделать перебор кнопок
             *  сделать текстинпут основываясь на старых данных
             *  Реализовать нажатие кнопки (_ [} X)
             *  Password, mail, phone, text - тип текстов ( Text )
             *users.txt  -> ( id, mail, password(hash), FIO )
             *shedule.txt -> ( id, user_id, date, time )
             *pacient.txt -> ( id, FIO, date)
             *
             * Поиск записей по дате
             * List<string> GetAllSheduleByUsers(User_ID);
             * List<string> GetSheduleForDay(User_ID, Date){ GetAll... }
            */
    public class FileSource
    {
        private List<int>
            user_id = new List<int>(),
            schedule_id = new List<int>(),
            schusr_id = new List<int>();
        private List<string> 
            user_mail = new List<string>(), 
            user_password = new List<string>(), 
            user_FIO = new List<string>(), 
            schedule_date = new List<string>(), 
            schedule_time = new List<string>();
        private string path_user, payh_shedule, path_pacient;

        private string[] fileUser, fileShedule, filePacient;

        public FileSource()
        {
            path_pacient = @"C:\Users\Admin\RiderProjects\Solution1\pacient.txt";
            path_user = @"C:\Users\Admin\RiderProjects\Solution1\user.txt";
            payh_shedule = @"C:\Users\Admin\RiderProjects\Solution1\shedule.txt";
            fileUser = File.ReadAllLines(path_user);
            fileShedule = File.ReadAllLines(payh_shedule);
            filePacient =  File.ReadAllLines(path_pacient);
        }

        public void FileWork() => Importer();

        public int SearchID(string mail)
        {
            int ID=0;
            for (int i = 0; i < user_mail.Count; i++)
            {
                if (mail == user_mail[i])
                {
                    ID = i;
                }
            }

            return ID;
        }


        // Поиск юзера для входа
        public string ValidUser(int i) =>user_mail[i];
        private void Importer()
        {
            if (fileUser.Length >0)
            {
                foreach (var str in fileUser)
                {
                    var split = str.Split(' ');
                    user_id.Add( Convert.ToInt32(split[0]));
                    user_mail.Add(split[1]);
                    user_password.Add(split[2]);
                    string fio = "";
                    for (var i = 3; i < split.Length; i++)
                    {
                        fio +=split[i] + ' ';
                    }
                    user_FIO.Add(fio);
                }
                // Console.WriteLine(user_id[0] + user_mail[0] + user_password[0] + user_FIO[0]);
            }

            if (fileShedule.Length >0)
            {
                foreach (var str in fileShedule)
                {
                    var split = str.Split(' ');
                    schedule_id.Add(Convert.ToInt32(split[0]));
                    schusr_id.Add(Convert.ToInt32(split[1]));
                    schedule_date.Add(split[2]);
                    schedule_time.Add(split[3]);
                }
                // Console.WriteLine(schedule_id[0]+schedule_date[0]+schedule_time[0]);
                // Thread.Sleep(1000);
            }
            
        }

        public void ExporterSchedule(int sch_id, int user_id, string sch_date, string sch_time)
        {
            schedule_id.Add(sch_id);
            schusr_id.Add(user_id);
            schedule_date.Add(sch_date);
            schedule_time.Add(sch_time);
            ReplaseExport(user_id);
        }

        private void ReplaseExport(int userID)
        {
            var strschedule = new List<string>();
            
            foreach (var str in fileShedule)
            {
                strschedule.Add(str);
            }
            strschedule.Add(schedule_id[schedule_id.Count-1].ToString() + ' ' + userID + ' ' + 
                            schedule_date[schedule_id.Count-1] + ' ' + schedule_time[schedule_id.Count-1]);

            var s = strschedule.ToArray();
            File.WriteAllText(payh_shedule, String.Join("\n",s));
            strschedule.Clear();
        }
        public List<string> ImporterSchedule(int userID)
        {
            var list = new List<string>();
            for(var i =0; i < schedule_date.Count;i++)
            {
                if (schusr_id[i] == userID) list.Add($"{schedule_date[i]} {schedule_time[i]}");
            } return list;
        }

        public void Export()
        {
            File.Create(@"C:\Users\Admin\RiderProjects\Solution1\pacient.txt");
            File.Create(@"C:\Users\Admin\RiderProjects\Solution1\user.txt");
            File.Create(@"C:\Users\Admin\RiderProjects\Solution1\schedule.txt");
            AllExporter();
        }
        private void AllExporter()
        {
            for (var i = 0; i < user_id.Count; i++)
            {
                var user = user_id[i].ToString() + ' ' + user_mail[i] + ' ' + user_password[i] +
                           ' ' + user_FIO[i];
                File.AppendAllText(path_user,$"\n{user}");
            }
            for (var i = 0; i < schedule_id.Count; i++)
            {
                var schedule =schedule_id[i].ToString() + ' ' + user_id[i].ToString() + ' ' + 
                              schedule_date[i] + ' ' + schedule_time[i];
                File.AppendAllText(payh_shedule, $"\n{schedule}");
            }
            for (var i = 0; i < user_FIO.Count; i++)
            {
                var pacient =user_id[i].ToString() + ' ' + user_FIO[i] + ' ' + schedule_date[i];
                File.AppendAllText(path_pacient,$"\n{pacient}" );
            }
        }

        public void DeleteSchedule(int i, int userID)
        {
            i--;
            schedule_date.RemoveAt(i);
            schedule_id.RemoveAt(i);
            schedule_time.RemoveAt(i);
            var strschedule = fileShedule.Where((t, index) => index != i).ToList();

            strschedule.Add(schedule_id[schedule_id.Count-1].ToString() + ' ' + userID + ' ' + 
                            schedule_date[schedule_id.Count-1] + ' ' + schedule_time[schedule_id.Count-1]);

            var s = strschedule.ToArray();
            File.WriteAllText(payh_shedule, String.Join("\n",s));
            strschedule.Clear();
        }
    }
}