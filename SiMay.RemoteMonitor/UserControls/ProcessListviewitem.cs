﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiMay.RemoteMonitor.UserControls
{
    public class ProcListViewItem : ListViewItem
    {
        public ProcListViewItem(int id, string processName, string windowName, int windowHandler, int memorySize, int threadCount, string filePath, int sessionId, string user)
            => this.Update(id, processName, windowName, windowHandler, memorySize, threadCount, filePath, sessionId, user);

        public void Update(int id, string processName, string windowName, int windowHandler, int memorySize, int threadCount, string filePath, int sessionId, string user)
        {
            this.SubItems.Clear();

            this.ProcessId = id;
            this.ProcessName = processName;
            this.WindowName = windowName;
            this.WindowHandler = windowHandler;
            this.ProcessMemorySize = memorySize;
            this.ProcessThreadCount = threadCount;
            this.SessionId = sessionId;
            this.User = user;

            this.Text = processName;
            this.SubItems.Add(windowName);
            this.SubItems.Add(windowHandler.ToString());
            this.SubItems.Add(((double)memorySize / 1024).ToString("0.00") + " MB");
            this.SubItems.Add(threadCount.ToString());
            this.SubItems.Add(sessionId.ToString());
            this.SubItems.Add(user);
            this.SubItems.Add(filePath);
        }

        public int ProcessId { get; set; }

        public string ProcessName { get; set; }

        public string WindowName { get; set; }

        public int WindowHandler { get; set; }

        public int ProcessMemorySize { get; set; }

        public int ProcessThreadCount { get; set; }

        public int SessionId { get; set; }
        public string User { get; set; }
    }
}
