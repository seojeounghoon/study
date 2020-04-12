using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

    }

    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName, bool overWrite = false)
        {
            if (overWrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, j.ToString());
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("오늘은 디자인패턴을 공부해보자");
            j.AddEntry("단일 책임 원칙에 대하여");
            WriteLine(j);

            //j.RemoveEntry(0);

            var f = new Persistence();
            var fileName = @"C:\Users\seo7777\Desktop\study\study\DesignPatterns\DesignPatterns\files\Journal.txt";
            f.SaveToFile(j, fileName, true);
            Process.Start(fileName);
        }
    }
}
