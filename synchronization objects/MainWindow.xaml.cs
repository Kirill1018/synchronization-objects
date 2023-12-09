﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Xaml;
using System.Security.Cryptography.X509Certificates;
namespace Synchronization_objects
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static long cop_byt = 0, tot_size_in_byt = 0;//скопированные байты и общий размер в байтах
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void cop_of_first_file_Click(object sender, RoutedEventArgs e)
        {
            Thread thread1 = new Thread(Window1);
            thread1.Start();
        }

        private void cop_of_sec_file_Click(object sender, RoutedEventArgs e)
        {
            Thread thread2 = new Thread(Window2);
            thread2.Start();
        }

        private void cop_of_third_file_Click(object sender, RoutedEventArgs e)
        {
            Thread thread3 = new Thread(Window3);
            thread3.Start();
        }

        private void cop_of_fourth_file_Click(object sender, RoutedEventArgs e)
        {
            Thread thread4 = new Thread(Window4);
            thread4.Start();
        }
        public void Window1()
        {
            string filename, filename_;
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "";
            dialog.DefaultExt = "";
            dialog.Filter = "";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                filename = dialog.FileName;
                Microsoft.Win32.SaveFileDialog dialog_ = new Microsoft.Win32.SaveFileDialog();
                dialog_.FileName = filename;
                dialog_.DefaultExt = "";
                dialog_.Filter = "";
                Nullable<bool> result_ = dialog_.ShowDialog();
                if (result_ == true)
                {
                    filename_ = dialog_.FileName;
                    byte[] buffer = new byte[1024];
                    long data = 0, length = new FileInfo(filename).Length;//начало копирования и длина файла
                    Mutex mutex = new Mutex();
                    mutex.WaitOne();
                    tot_size_in_byt += length;
                    mutex.ReleaseMutex();
                    using (Stream stream = new FileStream(filename_, FileMode.Create)) using (Stream stream_ = new FileStream(filename, FileMode.Open)) while (data < length)
                        {
                            int read = stream.Read(buffer, 0, buffer.Length);
                            stream_.Write(buffer, 0, read);
                            data += read;
                            mutex.WaitOne();
                            cop_byt += data;
                            mutex.ReleaseMutex();
                            progr_bar1.Value = 100 * data / length;
                            mutex.WaitOne();
                            progr_bar5.Value = 100 * cop_byt / tot_size_in_byt;
                            mutex.ReleaseMutex();
                        }
                }
            }
        }
        public void Window2()
        {
            string filename, filename_;
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "";
            dialog.DefaultExt = "";
            dialog.Filter = "";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                filename = dialog.FileName;
                Microsoft.Win32.SaveFileDialog dialog_ = new Microsoft.Win32.SaveFileDialog();
                dialog_.FileName = filename;
                dialog_.DefaultExt = "";
                dialog_.Filter = "";
                Nullable<bool> result_ = dialog_.ShowDialog();
                if (result_ == true)
                {
                    filename_ = dialog_.FileName;
                    byte[] buffer = new byte[1024];
                    long data = 0, length = new FileInfo(filename).Length;//начало копирования и длина файла
                    Mutex mutex = new Mutex();
                    mutex.WaitOne();
                    tot_size_in_byt += length;
                    mutex.ReleaseMutex();
                    using (Stream stream = new FileStream(filename_, FileMode.Create)) using (Stream stream_ = new FileStream(filename, FileMode.Open)) while (data < length)
                        {
                            int read = stream.Read(buffer, 0, buffer.Length);
                            stream_.Write(buffer, 0, read);
                            data += read;
                            mutex.WaitOne();
                            cop_byt += data;
                            mutex.ReleaseMutex();
                            progr_bar2.Value = 100 * data / length;
                            mutex.WaitOne();
                            progr_bar5.Value = 100 * cop_byt / tot_size_in_byt;
                            mutex.ReleaseMutex();
                        }
                }
            }
        }
        public void Window3()
        {
            string filename, filename_;
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "";
            dialog.DefaultExt = "";
            dialog.Filter = "";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                filename = dialog.FileName;
                Microsoft.Win32.SaveFileDialog dialog_ = new Microsoft.Win32.SaveFileDialog();
                dialog_.FileName = filename;
                dialog_.DefaultExt = "";
                dialog_.Filter = "";
                Nullable<bool> result_ = dialog_.ShowDialog();
                if (result_ == true)
                {
                    filename_ = dialog_.FileName;
                    byte[] buffer = new byte[1024];
                    long data = 0, length = new FileInfo(filename).Length;//начало копирования и длина файла
                    Mutex mutex = new Mutex();
                    mutex.WaitOne();
                    tot_size_in_byt += length;
                    mutex.ReleaseMutex();
                    using (Stream stream = new FileStream(filename_, FileMode.Create)) using (Stream stream_ = new FileStream(filename, FileMode.Open)) while (data < length)
                        {
                            int read = stream.Read(buffer, 0, buffer.Length);
                            stream_.Write(buffer, 0, read);
                            data += read;
                            mutex.WaitOne();
                            cop_byt += data;
                            mutex.ReleaseMutex();
                            progr_bar3.Value = 100 * data / length;
                            mutex.WaitOne();
                            progr_bar5.Value = 100 * cop_byt / tot_size_in_byt;
                            mutex.ReleaseMutex();
                        }
                }
            }
        }
        public void Window4()
        {
            string filename, filename_;
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "";
            dialog.DefaultExt = "";
            dialog.Filter = "";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                filename = dialog.FileName;
                Microsoft.Win32.SaveFileDialog dialog_ = new Microsoft.Win32.SaveFileDialog();
                dialog_.FileName = filename;
                dialog_.DefaultExt = "";
                dialog_.Filter = "";
                Nullable<bool> result_ = dialog_.ShowDialog();
                if (result_ == true)
                {
                    filename_ = dialog_.FileName;
                    byte[] buffer = new byte[1024];
                    long data = 0, length = new FileInfo(filename).Length;//начало копирования и длина файла
                    Mutex mutex = new Mutex();
                    mutex.WaitOne();
                    tot_size_in_byt += length;
                    mutex.ReleaseMutex();
                    using (Stream stream = new FileStream(filename_, FileMode.Create)) using (Stream stream_ = new FileStream(filename, FileMode.Open)) while (data < length)
                        {
                            int read = stream.Read(buffer, 0, buffer.Length);
                            stream_.Write(buffer, 0, read);
                            data += read;
                            mutex.WaitOne();
                            cop_byt += data;
                            mutex.ReleaseMutex();
                            progr_bar4.Value = 100 * data / length;
                            mutex.WaitOne();
                            progr_bar5.Value = 100 * cop_byt / tot_size_in_byt;
                            mutex.ReleaseMutex();
                        }
                }
            }
        }
    }
}