﻿using MJTop.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace DBCHM
{
    /// <summary>
    /// 管理 配置的连接字符串
    /// </summary>
    public static class ConfigUtils
    {
        /// <summary>
        /// 当前应用程序的名称
        /// </summary>
        private static string ConfigFileName = Path.GetFileNameWithoutExtension(AppDomain.CurrentDomain.FriendlyName).Replace(".vshost", "");
        /// <summary>
        /// 定义配置存放的路径
        /// </summary>
        public static string AppPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData, Environment.SpecialFolderOption.Create), ConfigFileName);

        /// <summary>
        /// sqlite db文件的存放路径
        /// </summary>
        private static string ConfigFilePath = string.Empty;

        /// <summary>
        /// 针对配置的 数据库操作对象
        /// </summary>
        private static DB db = null;

        /// <summary>
        /// 初始化静态数据
        /// 将sqlite数据库写入  C:\Users\用户名\AppData\Local\DBChm 目录中
        /// </summary>
        static ConfigUtils()
        {
            try
            {
                if (!ZetaLongPaths.ZlpIOHelper.DirectoryExists(AppPath))
                {
                    ZetaLongPaths.ZlpIOHelper.CreateDirectory(AppPath);                   
                }
                AddSecurityControll2Folder(AppPath);
                ConfigFilePath = Path.Combine(AppPath, ConfigFileName + ".db");
                Init();
            }
            catch (Exception ex)
            {
                LogUtils.LogError("ConfigUtils初始化", Developer.SysDefault, ex);
            }
        }

        /// <summary>
        /// 初始化创建配置数据库
        /// </summary>
        private static void Init()
        {
            db = DBMgr.UseDB(DBType.SQLite, ConfigFilePath);

            string strSql = @"create table DBCHMConfig
            (
               Id integer PRIMARY KEY autoincrement,
               Name nvarchar(200) unique,
	             DBType varchar(30),
               Server varchar(100),
               Port integer,
               DBName varchar(100),
	             Uid varchar(50),
               Pwd varchar(100),
                ConnTimeOut integer,
	             ConnString text,
                Modified text
            )";

            //表不存在则创建 连接字符串 配置表
            if (db.Info.TableNames == null || !db.Info.TableNames.Contains(nameof(DBCHMConfig), StringComparer.OrdinalIgnoreCase))
            {
                db.ExecSql(strSql);
                //执行后，刷新实例 表结构信息
                db.Info.Refresh();
            }
            else
            {
                // v1.7.3.7 版本 增加 连接超时 与 最后连接时间
                var info = db.Info;
                if(!info.IsExistColumn(nameof(DBCHMConfig), nameof(DBCHMConfig.Modified)))
                {
                    var configs = db.GetListDictionary("select * from " + nameof(DBCHMConfig));

                    db.Info.DropTable(nameof(DBCHMConfig));

                    db.ExecSql(strSql);

                    //执行后，刷新实例 表结构信息
                    db.Info.Refresh();

                    if (configs != null && configs.Count > 0)
                    {
                        foreach (var config in configs)
                        {
                            try
                            {
                                db.Insert(config, nameof(DBCHMConfig));
                            }
                            catch (Exception ex)
                            {
                                LogUtils.LogError("Init", Developer.SysDefault, ex, config);
                            }
                        }

                        db.ExecSql("update " + nameof(DBCHMConfig) + " set ConnTimeOut = 120 ");
                    }
                }
            }
        }



        /// <summary>
        /// 判断磁盘路径下是否安装存在某个文件，最后返回存在某个文件的路径
        /// </summary>
        /// <param name="installPaths"></param>
        /// <param name="installPath"></param>
        /// <returns></returns>
        public static bool IsInstall(string[] installPaths, out string installPath)
        {
            installPath = string.Empty;
            var driInfos = DriveInfo.GetDrives();
            foreach (DriveInfo dInfo in driInfos)
            {
                if (dInfo.DriveType == DriveType.Fixed)
                {
                    foreach (string ipath in installPaths)
                    {
                        string path = Path.Combine(dInfo.Name, ipath);
                        if (File.Exists(path))
                        {
                            installPath = path;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 检测是否安装某个软件，并返回软件的卸载安装路径
        /// </summary>
        /// <param name="softName"></param>
        /// <param name="installPath"></param>
        /// <returns></returns>
        public static bool CheckInstall(string softName, string str_exe, out string installPath)
        {
            //即时刷新注册表
            SHChangeNotify(0x8000000, 0, IntPtr.Zero, IntPtr.Zero);

            installPath = string.Empty;

            bool isFind = false;
            var uninstallNode = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall", false);
            if (uninstallNode != null)
            {
                //LocalMachine_64
                using (uninstallNode)
                {
                    foreach (var subKeyName in uninstallNode.GetSubKeyNames())
                    {
                        var subKey = uninstallNode.OpenSubKey(subKeyName);
                        string displayName = (subKey.GetValue("DisplayName") ?? string.Empty).ToString();
                        string path = (subKey.GetValue("UninstallString") ?? string.Empty).ToString();
                        Console.WriteLine(displayName);
                        if (displayName.Contains(softName) && !string.IsNullOrWhiteSpace(path))
                        {
                            installPath = Path.Combine(Path.GetDirectoryName(path), str_exe);
                            if (File.Exists(installPath))
                            {
                                isFind = true;
                                break;
                            }
                        }
                    }
                }
            }
            

            if (!isFind)
            {
                //LocalMachine_32
                uninstallNode = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", false);
                using (uninstallNode)
                {
                    foreach (var subKeyName in uninstallNode.GetSubKeyNames())
                    {
                        var subKey = uninstallNode.OpenSubKey(subKeyName);
                        string displayName = (subKey.GetValue("DisplayName") ?? string.Empty).ToString();
                        string path = (subKey.GetValue("UninstallString") ?? string.Empty).ToString();
                        Console.WriteLine(displayName);
                        if (displayName.Contains(softName) && !string.IsNullOrWhiteSpace(path))
                        {
                            installPath = Path.Combine(Path.GetDirectoryName(path), str_exe);
                            if (File.Exists(installPath))
                            {
                                isFind = true;
                                break;
                            }
                        }
                    }
                }
            }
            return isFind;
        }

        [DllImport("shell32.dll")]

        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);



        /// <summary>
        ///为文件夹添加users，everyone用户组的完全控制权限
        /// </summary>
        /// <param name="dirPath"></param>
        public static void AddSecurityControll2Folder(string dirPath)
        {
            //获取文件夹信息
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if (dir.Exists)
            {
                //获得该文件夹的所有访问权限
                System.Security.AccessControl.DirectorySecurity dirSecurity = dir.GetAccessControl(AccessControlSections.All);
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                //添加ereryone用户组的访问权限规则 完全控制权限
                FileSystemAccessRule everyoneFileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                //添加Users用户组的访问权限规则 完全控制权限
                FileSystemAccessRule usersFileSystemAccessRule = new FileSystemAccessRule("Users", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                bool isModified = false;
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, everyoneFileSystemAccessRule, out isModified);
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, usersFileSystemAccessRule, out isModified);
                //设置访问权限
                dir.SetAccessControl(dirSecurity);
            }
        }

        /// <summary>
        /// 添加或修改配置连接
        /// </summary>
        /// <param name="dbCHMConfig"></param>
        public static void Save(NameValueCollection dbCHMConfig)
        {
            db.Save(dbCHMConfig, "DBCHMConfig");
        }

        public static void UpLastModified(int id)
        {
            db.ExecSql("update DBCHMConfig set Modified='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where id=" + id);
        }

        /// <summary>
        /// 删除连接
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            db.Delete("DBCHMConfig", "Id", id);
        }

        /// <summary>
        /// 查询出所有配置的连接
        /// </summary>
        /// <returns></returns>
        public static List<DBCHMConfig> SelectAll()
        {
            return db.GetDataTable("select * from DBCHMConfig order by Modified desc ").ConvertToListObject<DBCHMConfig>();
        }

        /// <summary>
        /// 得到其中1个连接
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DBCHMConfig Get(int id)
        {
            return db.GetDataTable("select * from DBCHMConfig where id = " + id).ConvertToListObject<DBCHMConfig>().FirstOrDefault();
        }

        /// <summary>
        /// 判断配置表是否存在连接字符串
        /// </summary>
        /// <returns></returns>
        public static bool HasValue()
        {
            string strSql = "select count(1) from DBCHMConfig";
            return db.Single<int>(strSql, 0) > 0;
        }

    }
}
