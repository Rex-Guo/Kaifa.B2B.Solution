﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
namespace Kaifa.B2B.VendorAlloc
{
    public   class AllocTask
    {
        private Timer _timer;
        private string _strDir;
        private string _connstring;
        private string _backupDir;
        private string _warehouse;
        public AllocTask(string strDir, string backupDir, string connstring,string warehouse)
        {
            _strDir = strDir;
            _connstring = connstring;
            _backupDir = backupDir;

            _warehouse = warehouse;
            if (!Directory.Exists(_backupDir))
            {
                Directory.CreateDirectory(_backupDir);
            }

            if (!Directory.Exists(_strDir))
            {
                Directory.CreateDirectory(_strDir);
            }

        }

        public void Start() {
            _timer = new Timer(new TimerCallback(Do));
            _timer.Change(20 * 1000, 3*1000);
        }
        private void Do(object obj) {
            lock (obj)
            {
                //List<FileInfo> listFiles = new List<FileInfo>(); //保存所有的文件信息  
               
                DirectoryInfo directory = new DirectoryInfo(_strDir);
                FileInfo[] fileInfoArray = directory.GetFiles();
                if (fileInfoArray.Length > 0)
                {
                    foreach (FileInfo file in fileInfoArray)
                    {
                        if (!file.IsReadOnly && (file.Extension.ToLower() == ".csv" || file.Extension.ToLower() == ".txt"))
                        {
                            Console.WriteLine(file.FullName);
                            AllocProcess alloc = new AllocProcess(file.FullName, _connstring, _warehouse);
                            alloc.Read();

                            file.MoveTo(Path.Combine(_backupDir, file.Name + DateTime.Now.ToString(".yyyyMMddHHmmssfff") + ".bk"));
                            Console.WriteLine("move......" + _backupDir);
                        }

                    }


                }
            }
        }
        public void Stop() {
            if (_timer != null)
            {
                _timer.Dispose();
            }
        }

    }
}
