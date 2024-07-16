﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace Bank_System.Classes
{
    static class MyFile
    {
        public static void AddRecord(User user,string path)// for add book in specific file
        {
            FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(user.ID + "|" + user.Username + "|" + user.Password + "|" + user.Permission );
            streamWriter.Close();
            fileStream.Close();
        }
        public static void DeleteRecord( User user, string Path)// for delete book in specific file
        {
            bool flag = false;
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(myFile);
            string record;
            string SecondaryKey ="";
            //Example of User attributes : ID 0 | Username 1 | Password 2 | Permission 3 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                if(user.ID == Fields[0] )
                {
                    SecondaryKey = Fields[0] + Fields[1];
                    user.ID = "*";                       
                    flag = true;
                    break;
                }
            }
            if(!flag) MessageBox.Show("User not found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            sr.Close();
            myFile.Close();
            if(flag)UpdateRecord( user, Path, SecondaryKey);
        }
        public static void UpdateRecord( User user, string Path, string SecondaryKey="")// for Update book in specific file
        {
            bool flag = false;
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(myFile);
            string record;
            //Example of User attributes : ID 0 | Username 1 | Password 2 | Permission 3 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                User user2 = new User(Fields.ToList());
               
                string SecondaryKey2 = user2.ID + user2.Username;
                if (SecondaryKey == SecondaryKey2)
                {
                    user2.ID         =user.ID;
                    user2.Username   =user.Username;
                    user2.Password   =user.Password;
                    user2.Permission =user.Permission;
               
                    flag = true;
                    break;
                }
            }
           
            if (!flag) MessageBox.Show("User not found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            
            sr.Close();
            myFile.Close();
               
            
            CreateFile(Path);

          
        }
        private static bool Search(int id,string Path)
        {
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(myFile);
            string record;
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                if (Fields[0] == id.ToString())
                {
                    return true;
                }
            }
            sr.Close();
            myFile.Close();
            return false;
        }
        public static string LoadFile(string Path, TextBox Place)
        {
            Place.Text = "ID\r\t|\r\tUsername\r\t|\rPassword\r\t|\rPermission\r\n\r\n";
            FileStream myFile = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(myFile);
            string record;
            //Example of User attributes : ID 0 | Username 1 | Password 2 | Permission 3 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                Place.Text += Fields[0] + "\r\t|\r\t" + Fields[1] + "\r\t|\r\t" + Fields[2] + "\r\t|\r\t" + Fields[3] + "\r\t|\r\t" + double.Parse(Fields[4]) + "\r\t|\r\t" + int.Parse(Fields[5]) + "\r\n";
                
            }
            sr.Close();
            myFile.Close();
            return Place.Text;

        }
        private static void CreateFile(string Path)
        {
            FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            foreach (User user in UserOperations.UsersList)
            {              
                streamWriter.WriteLine(user.ID + "|" + user.Username + "|" + user.Password + "|" + user.Permission);
            }
            streamWriter.Close();
            fileStream.Close();
        }

        public static void LoadUsersFromFileToList()
        {
            FileStream myFile = new FileStream(UserOperations.Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(myFile);
            string record;
            int maxID = 0;
            //Example of User attributes : ID 0 | Username 1 | Password 2 | Permission 3 (As Written in file)
            while ((record = sr.ReadLine()) != null)
            {
                string[] Fields = record.Split('|');
                if (Fields[0].Trim() != "*") // We don't add deleted users to list
                {
                    User user = new User(Fields.ToList());
                    UserOperations.UsersList.Add(user);
                    int currentID = int.Parse(user.ID);
                    if (currentID > maxID)
                    {
                        maxID = currentID;
                    }
                }
            }
            User.id = maxID;
            sr.Close();
            myFile.Close();
        }
    }
}
