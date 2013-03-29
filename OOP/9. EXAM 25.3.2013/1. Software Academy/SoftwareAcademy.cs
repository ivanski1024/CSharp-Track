using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }   

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    abstract class Course : ICourse
    {
        public string Name { get; set; }
        public ITeacher Teacher { get; set; }

        private List<string> topics;

        public virtual void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        protected Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            //TODO: Ask about "Topics=[..]"
            output.Append(string.Format(": Name={0};", this.Name));
            if (this.Teacher != null)
            {
                output.Append(string.Format(" Teacher={0};", this.Teacher.Name));
            }

            int topicsCount = this.topics.Count;
            if (topicsCount != 0)
            {
                output.Append(string.Format(" Topics=["));
                for (int topic = 0; topic < topics.Count; topic++)
                {
                    if (topic != 0)
                    {
                        output.Append(", ");
                    }
                    output.Append(topics[topic]);
                }

                output.Append("];");
            }
            return output.ToString();
        }
    }

    class LocalCourse : Course, ILocalCourse
    {
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab { get; set; }

        public override void AddTopic(string topic)
        {
            base.AddTopic(topic);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("LocalCourse");
            output.Append(base.ToString());
            output.Append(string.Format(" Lab={0}", this.Lab));
            return output.ToString();
        }
    }

    class OffsiteCourse : Course, IOffsiteCourse
    {
        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town { get; set; }
        public override void AddTopic(string topic)
        {
            base.AddTopic(topic);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("OffsiteCourse");
            output.Append(base.ToString());
            output.Append(string.Format(" Town={0}", this.Town));
            return output.ToString();
        }
    }

    public class Teacher : ITeacher
    {
        public List<ICourse> Courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.Courses = new List<ICourse>();
        }

        public string Name { get; set; }

        public void AddCourse(ICourse course)
        {
            Courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("Teacher: Name={0}", this.Name));
            int coursesCount = this.Courses.Count;

            if (coursesCount != 0)
            {
                output.Append("; Courses=[");
                for (int course = 0; course < coursesCount; course++)
                {
                    if (course != 0)
                    {
                        output.Append(", ");
                    }
                    output.Append(Courses[course].Name);
                }
                output.Append("]");
            }

            return output.ToString();
        }
    }
}
