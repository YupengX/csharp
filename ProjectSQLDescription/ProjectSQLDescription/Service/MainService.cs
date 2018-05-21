using ProjectSQLDescription.POJO;
using ProjectSQLDescription.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSQLDescription.Service
{
    class MainService
    {
        /// <summary>
        /// 读取当前目录下所以json文件，将json转换为对象
        /// </summary>
        /// <param name="dirPath">json数据文件父目录</param>
        /// <returns>ProjectInfo对象的list集合</returns>
        public List<ProjectInfo> getObjsFromAllDirJsonFiles(string dirPath)
        {
            List<ProjectInfo> projectList = new List<ProjectInfo>();
            List < FileInfo > fileList = FileUtils.getAllJSONFilesFromCurrentDir(dirPath);
            if (fileList != null && fileList.Count > 0)
            {
                foreach (FileInfo item in fileList)
                {
                    string json = FileUtils.readFile(item.FullName);
                    ProjectInfo projectInfo = JSONUtils.translateJSON2Object<ProjectInfo>(json);
                    projectList.Add(projectInfo);
                }
            }
            return projectList;
        }
        /// <summary>
        /// 读取当前目录下所以json文件，将json转换为对象
        /// </summary>
        /// <param name="dirPath">json数据文件父目录</param>
        /// <returns>ProjectInfo对象的Dictionary集合</returns>
        public Dictionary<string, ProjectInfo> getDicFromAllDirJsonFiles(string dirPath)
        {
            Dictionary < string, ProjectInfo > dic = new Dictionary<string, ProjectInfo>();
            List<FileInfo> fileList = FileUtils.getAllJSONFilesFromCurrentDir(dirPath);
            if (fileList != null && fileList.Count > 0)
            {
                foreach (FileInfo item in fileList)
                {
                    string json = FileUtils.readFile(item.FullName);
                    ProjectInfo projectInfo = JSONUtils.translateJSON2Object<ProjectInfo>(json);
                    dic.Add(projectInfo.ProjectId, projectInfo);
                }
            }
            return dic;
        }
    }
}
