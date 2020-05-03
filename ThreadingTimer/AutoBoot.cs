using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//Класс имеет два метода, один метод для считывания данных с автозагрузки, а другой для записи данных из автозагрузки
//TODO reestr 

    class AutoBoot
    {
        public string NameSoft;

        string path = Assembly.GetExecutingAssembly().Location;

        

        public bool readReestrAutoBoot()
        {
            RegistryKey reg;
            
            reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

            if (reg.GetValue(NameSoft) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool writeReestrAutoBoot(bool check)
        {
           
                RegistryKey reg;
                reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");

                try
                {
                    if (check)
                    {
                        reg.SetValue(NameSoft, path);
                    }
                    else
                    {
                        reg.DeleteValue(NameSoft);
                    }

                    reg.Flush();
                    reg.Close();
                }
                catch (Exception)
                {
                    return false;
                }    
                return true;
           
            
        }

    }

