using System;
using System.Collections.Generic;
using System.IO;
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
            schedule_id = new List<int>();
        private List<string> 
            user_mail = new List<string>(), 
            user_password = new List<string>(), 
            user_FIO = new List<string>(), 
            schedule_date = new List<string>(), 
            schedule_time = new List<string>();
        private string path_user, payh_shedule, path_pacient;


        public FileSource()
        {
            path_pacient = @"C:\Users\Admin\RiderProjects\Solution1\pacient.txt";
            path_user = @"C:\Users\Admin\RiderProjects\Solution1\user.txt";
            payh_shedule = @"C:\Users\Admin\RiderProjects\Solution1\shedule.txt";
        }

        public void FileWork() => Importer();

        // Поиск юзера для входа
        public string ValidUser(int i) =>user_mail[i];


        private void Importer()
        {
            var fileUser = File.ReadAllLines(path_user);
            var fileShedule = File.ReadAllLines(payh_shedule);
            foreach (var str in fileUser)
            {
                var split = str.Split(' ');
                user_id.Add( Convert.ToInt32(split[0]));
                user_mail.Add(split[1]);
                user_password.Add(split[2]);
                string fio = "";
                for (int i = 3; i < split.Length; i++)
                {
                    fio +=split[i] + ' ';
                }
                user_FIO.Add(fio);
            }
            Console.WriteLine(user_id[0] + user_mail[0] + user_password[0] + user_FIO[0]);
            foreach (var str in fileShedule)
            {
                var split = str.Split(' ');
                schedule_id.Add(Convert.ToInt32(split[0]));
                schedule_date.Add(split[2]);
                schedule_time.Add(split[3]);
            }
            Console.WriteLine(schedule_id[0]+schedule_date[0]+schedule_time[0]);
        }

        public void ExporterSchedule(int sch_id, int user_id, string sch_date, string sch_time)
        {
            schedule_id.Add(sch_id);
            this.user_id.Add(user_id);
            schedule_date.Add(sch_date);
            schedule_time.Add(sch_time);
            var schedule =sch_id.ToString() + ' ' + user_id.ToString() + ' ' + sch_date + ' ' +
                          sch_time;
            File.AppendAllText(payh_shedule, $"\n{schedule}");
        }
        public List<string> ImporterSchedule()
        {
            var list = new List<string>();
            for (var index = 0; index < schedule_id.Count; index++)
            {
                list.Add($"{schedule_date[index]} {schedule_time[index]}");
            }

            return list;
        }
        public void AllExporter(int i)
        {
            string user = user_id[i].ToString() + ' ' + user_mail[i] + ' ' + user_password[i] + ' ' + user_FIO[i];
            string pacient =user_id[i].ToString() + ' ' + user_FIO[i] + ' ' + schedule_date[i];
            string schedule =schedule_id[i].ToString() + ' ' + user_id[i].ToString() + ' ' + schedule_date[i] + ' ' +
                             schedule_time[i];
            // File.AppendAllText(path_user, $"{user}");
            File.AppendAllText(path_user,$"\n{user}");
            File.AppendAllText(path_pacient,$"\n{pacient}" );
            File.AppendAllText(payh_shedule, $"\n{schedule}");
        }

        public void DeleteSchedule(int i)
        {
            i--;
            schedule_date.RemoveAt(i);
            schedule_id.RemoveAt(i);
            schedule_time.RemoveAt(i);
        }
    }
}