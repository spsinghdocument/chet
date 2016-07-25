using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService3
{
    class FileWatcher
    {
        private FileSystemWatcher  _fileWatcher;
        public FileWatcher()
        {
            _fileWatcher = new FileSystemWatcher(pathlocation());
            
            _fileWatcher.Created += new FileSystemEventHandler(_fileWatcher_created);
            _fileWatcher.Deleted += new FileSystemEventHandler(_fileWatcher_Deleted);
            _fileWatcher.Changed += new FileSystemEventHandler(_fileWatcher_Changed);
            _fileWatcher.EnableRaisingEvents = true;
        }
        private string pathlocation()
        {
            string value = string.Empty;

            try
            {
                value = @"D:\snr\vido\WINDOW SERVICE";
            }
            catch (Exception ex)
            {

            }
            return value;
        }

        void _fileWatcher_created(object sender,FileSystemEventArgs e)
        {
            Logger.Log(string.Format("File created : path {0},name {1}", e.FullPath, e.Name));
        }
        void _fileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("File Dleted : path {0},name {1}", e.FullPath, e.Name));
        }
        void _fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Logger.Log(string.Format("File changed : path {0},name {1}", e.FullPath, e.Name));
        }
    }
}
